class Parser {
    
    final int NONE = 0;
    final int OPERATOR = 1;
    final int NUMBER = 2;
    
    final String EOE = "\0";
    
    private String exp;
    private int expIdx;
    private String token;
    private int tokType;
    
    //수식 계산
    public double evaluate(String expstr) throws ParserException {
        double result;
        exp = expstr;
        expIdx = 0;
        
        lex();
        if (token.equals(EOE))
            handleError();
        
        result = expr();
        
        if (!token.equals(EOE))
            handleError();
        
        return result;
    }
    
    private double expr() throws ParserException {
        char op;
        double result;
        double nextResult;
        
        result = term();
        
        while ((op = token.charAt(0)) == '+' || op == '-') {
            lex();
            nextResult = term();
            switch (op) {
                case '+' -> result += nextResult;
                case '-' -> result -= nextResult;
            }
        }
        return result;
    }
    
    private double term() throws ParserException {
        char op;
        double result;
        double nextResult;
        
        result = factor();
        
        while ((op = token.charAt(0)) == '*' ||  op == '÷') {
            lex();
            nextResult = factor();
            switch (op) {
                case '*' -> result *= nextResult;
                case '÷' -> {
                    if (nextResult == 0.0) handleError();
                    result /= nextResult;
                }
            }
        }
        return result;
    }
    
    private double factor() throws ParserException {
        double result;
        
        if (token.equals("(")) {
            lex();
            result = expr();
            if (!token.equals(")"))
                handleError();
            lex();
        } else result = number();
        
        return result;
    }
    
    private double number() throws ParserException {
        double result = 0.0;
        
        if (tokType == NUMBER) {
            result = Double.parseDouble(token);
            lex();
        } else {
            handleError();
        }
        return result;
    }
    
    
    private void handleError() throws ParserException {
        throw new ParserException("Error");
    }
    
    private void lex() {
        tokType = NONE;
        token = "";
        
        if (expIdx == exp.length()) {
            token = EOE;
            return;
        }
        
        if (isOperator(exp.charAt(expIdx))) {
            token += exp.charAt(expIdx);
            expIdx++;
            tokType = OPERATOR;
        } else if (Character.isDigit(exp.charAt(expIdx))) {
            while (!isOperator(exp.charAt(expIdx))) {
                token += exp.charAt(expIdx);
                expIdx++;
                if (expIdx >= exp.length()) 
                    break;
            }
            tokType = NUMBER;
        } else {
            token = EOE;
        }
    }
    
    private boolean isOperator(char c) {
        return "+-*%^=()÷".indexOf(c) != -1;
    }
    
} 

