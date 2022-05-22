using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Calculator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        //V operace znamená odmocnina jelikož √ blblo

        //Objekt všech operací které kalkulačka podporuje
        Dictionary<string, Func<float, float, float>> operators = new Dictionary<string, Func<float, float, float>>() {
            { "*", (float a, float b) => b * a },
            { "/", (float a, float b) => b / a },
            { "-", (float a, float b) => b - a },
            { "+", (float a, float b) => b + a },
            { "^", (float a, float b) => (float)Math.Pow((double)b, (double)a) },
            { "V", (float a, float _) => (float)Math.Sqrt((double)a) }
        };

        //Objekt přednosti jednotlivých operací. Čím vyšší číslo tím vyšší přednost
        Dictionary<string, int> operatorPredence = new Dictionary<string, int>() {
            { "*", 3},
            { "/", 3 },
            { "-", 2 },
            { "+", 2 },
            { "^", 4 },
            { "V", 4 }
        };

        //předchozí výsledek pro ans tlačítko
        float prevResult = 0f;

        //automaticky aktualizovat display když se změní příklad v kódu
        private string _toDisplay = "";
        public string toDisplay { 
            get { return _toDisplay; }
            set {
                _toDisplay = value;
                lbDisplay.Text = _toDisplay;
            }
        }

        

        private void Form1_Load(object sender, EventArgs e) {
            lbDisplay.Text = toDisplay;
        }

        //na stisknutí čísla
        private void onDigitClick(object sender, EventArgs e) {
            Button btn = sender as Button;

            if (btn.Text == ".") {
                if(String.IsNullOrEmpty(getCurrentNumber()) || toDisplay == "-") {
                    toDisplay += "0.";
                    return;
                } else if(getCurrentNumber().Contains(".")) {
                    return;
                }
            }

            if (btn.Name == "ans")
                toDisplay += prevResult.ToString();
            else
                toDisplay += btn.Text;
        }

        //na stisknutí operace
        private void onOperatorClick(object sender, EventArgs e) {
            Button btn = sender as Button;
            if (String.IsNullOrEmpty(toDisplay)) {
                if (btn.Name == "minus" || btn.Text == "(")
                    toDisplay = btn.Text;
                else if (btn.Name == "sqrt")
                    toDisplay = "V";
                return;
            }

            string lastChar = toDisplay.Last<char>().ToString();//poslední znak
            bool isNumber = IsNumeric(lastChar);//je číslo
            if (btn.Text == "(") {
                if (isNumber) return;
            } else if (btn.Name == "square" || btn.Name == "powerOfN") {//pokud operace je na druhou nebo na n a poslední znak není číslo nebo zavorka, nic dělat nebudem
                if(lastChar != ")" && !isNumber) return;
            } else if (!isNumber || lastChar == ".") {//pokud poslední znak je znamenko nebo tečka taky nic nebudem dělat
                return;
            }


            if (btn.Name == "square")//na druhou
                toDisplay += "^2";
            else if (btn.Name == "powerOfN")//na N-tou
                toDisplay += "^";
            else if (btn.Name == "sqrt")//odmocnina
                toDisplay += "V";
            else
                toDisplay += btn.Text;
        }

        private void evaluate(object sender, EventArgs e) {//tlačítko =
            if (toDisplay.Contains("/0")) {//pokud je někde děleno 0 tak hodíme error
                lbEquation.Text = "Error: Dělení 0";
                return;
            }
            Stack<string> resStack = toRPNStack(toDisplay);//RPN stack je reverse polish notation zdroje -> https://en.wikipedia.org/wiki/Reverse_Polish_notation#Converting_from_infix_notation
            if (resStack.Count == 0)
                return;
            float res = evaluateRPN(resStack);//vyhodnotíme příklad ktery je převeden na RPN notaci

            if (float.IsNaN(res))
                return;

            toDisplay = "";
            lbEquation.Text = res.ToString();
            prevResult = res;
        }

        private void undo(object sender, EventArgs e) {//DEL tlačítko
            if (String.IsNullOrEmpty(toDisplay))
                return;
            toDisplay = toDisplay.Remove(toDisplay.Length - 1);
        }

        private void clear(object sender, EventArgs e) {//AC tlačítko
            toDisplay = "";
        }

        private string getCurrentNumber() {//vrátí nynější číslo toto je důležité kvůli desetinné čárce
            int lastIndexOfNumber = toDisplay.LastIndexOfAny(new char[]{ '(', '-', '+', '*', '/'});
            if (lastIndexOfNumber == -1)
                return toDisplay;

            return toDisplay.Substring(lastIndexOfNumber + 1);
        }
        //toto jsem našel na internetu vrátí true nebo false jestli je string číslo
        public bool IsNumeric(string text) { 
            double _out; 
            return double.TryParse(text, out _out); 
        }

        private short getPredence(string op1, string op2) {//porovná 2 operatory a vratí 1, 0, -1 zavisí na přednosti operátoru
            if (operatorPredence[op1] > operatorPredence[op2])
                return 1;
            if (operatorPredence[op1] < operatorPredence[op2])
                return -1;
            return 0;
        }

        private float evaluateRPN(Stack<string> stack) {//vyhodnotí RPN stack
            stack = ReverseStack(stack);
            Stack<float> outputStack = new Stack<float>();
            while(stack.Count != 0) {
                if (operators.ContainsKey(stack.Peek())) {
                    outputStack.Push(operation(stack.Pop(), ref outputStack));
                } else {
                    outputStack.Push(float.Parse(stack.Pop()));
                }
            }

            return outputStack.Pop();
        }
        private Stack<string> toRPNStack(string equation) {//převede infix notaci na postfix  https://en.wikipedia.org/wiki/Shunting-yard_algorithm

            Stack<string> outputStack = new Stack<string>();
            Stack<float> numberStack = new Stack<float>();
            Stack<string> operatorStack = new Stack<string>();

            //rozdělí příklad na jednotlivé čísla, operace, závorky => tokeny
            string[] tokens = Regex.Split(equation, @"([\*/\-+\^V\(\)])");
            if (String.IsNullOrEmpty(tokens[0]))
                tokens = tokens.Skip(1).ToArray();

            //algoritmus z pseudo algoritmu z wikipedie https://cs.wikipedia.org/wiki/Algoritmus_shunting-yard (detailní popis algoritmu)
            foreach (string t in tokens) {
                if (IsNumeric(t) || t == "𝜋") {
                    if (t == "𝜋")
                        outputStack.Push(Math.PI.ToString());
                    else
                        outputStack.Push(t);
                } else if (operators.ContainsKey(t)) {
                    while (operatorStack.Count != 0 && operators.ContainsKey(operatorStack.Peek())
                        && (getPredence(operatorStack.Peek(), t) == 1 || (getPredence(operatorStack.Peek(), t) == 0 && t != "^"))
                        && operatorStack.Peek() != "(") {

                        outputStack.Push(operatorStack.Pop());
                    }
                    operatorStack.Push(t);
                } else if (t == "(") {
                    operatorStack.Push(t);
                } else if (t == ")") {
                    while (operatorStack.Peek() != "(") {
                        outputStack.Push(operatorStack.Pop());
                    }
                    if (operatorStack.Peek() == "(")
                        operatorStack.Pop();

                }
            }
            while (numberStack.Count != 0 || operatorStack.Count != 0) {
                if (operatorStack.Count == 0) {
                    lbEquation.Text = "Syntax error";
                    return new Stack<string>();
                } else if (operatorStack.Peek() == "(" || operatorStack.Peek() == ")") {
                    lbEquation.Text = "Chybně zadané závorky";
                    return new Stack<string>();
                } else {
                    outputStack.Push(operatorStack.Pop());
                }
            }
            return outputStack;
        }



        private float operation(string op, ref Stack<float> stack) {//pomocná funkce, provede operaci a vrátí výsledek do stacku
            if (op == "V")
                return operators[op](stack.Pop(), 0f);

            return operators[op](stack.Pop(), stack.Pop());
        }


        
        private Stack<string> ReverseStack(Stack<string> stack) {//obrátí stack
            Stack<string> reversed = new Stack<string>();
            while(stack.Count != 0)
                reversed.Push(stack.Pop());

            return reversed;
        }
    }

}
