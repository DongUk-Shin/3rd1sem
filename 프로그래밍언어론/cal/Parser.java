class Parser {
    
    final int NONE = 0;
    final int DELIMITER = 1;
    final int VARIABLE = 2;
    final int NUMBER = 3;
    
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
            return 0;
        
        result = expr();
        
        if (!token.equals(EOE)) 
            handleErr();
        
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
                case '-' -> result -= nextResult;
                case '+' -> result += nextResult;
            };
        }
        return result;
    }
    
    private double term() throws ParserException {
        char op;
        double result;
        double nextResult;
        
        result = factor();
        
        while ((op = token.charAt(0)) == '*' ||
                op == '÷') {
            lex();
            nextResult = factor();
            switch (op) {
                case '*' -> result *= nextResult;
                case '÷' -> {
                    if (nextResult == 0.0)  handleErr();
                    result /= nextResult;
                }
            };
        }
        return result;
    }
    
    private double factor() throws ParserException {
        double result ;
        
        if (token.equals("(")) {
            lex();
            result = expr();
            if (!token.equals(")"))
                handleErr();
            lex();
        } else result = atom();
        
        return result;
    }
    
    private double atom() throws ParserException
    {
        double result = 0.0;
        
        if (tokType == NUMBER) {
            result = Double.parseDouble(token);
            lex();
        } else {
            handleErr();
        }
        
        return result;
    }
    
    
    private void handleErr() throws ParserException {
        throw new ParserException("Error");
    }
    
    private void lex() {
        tokType = NONE;
        token = "";
        
        while (expIdx < exp.length() &&
                Character.isWhitespace(exp.charAt(expIdx))) ++expIdx;
        
        if (expIdx == exp.length()) {
            token = EOE;
            return;
        }
        
        if (isDelim(exp.charAt(expIdx))) { 
            token += exp.charAt(expIdx);
            expIdx++;
            tokType = DELIMITER;
        } else if (Character.isLetter(exp.charAt(expIdx))) {
            while (!isDelim(exp.charAt(expIdx))) {
                token += exp.charAt(expIdx);
                expIdx++;
                if (expIdx >= exp.length()) break;
            }
            tokType = VARIABLE;
        } else if (Character.isDigit(exp.charAt(expIdx))) { 
            while (!isDelim(exp.charAt(expIdx))) {
                token += exp.charAt(expIdx);
                expIdx++;
                if (expIdx >= exp.length()) break;
            }
            tokType = NUMBER;
        } else { 
            token = EOE;
            return;
        }
    }
    
    private boolean isDelim(char c) {
        if ((" +-*%^=()÷".indexOf(c) != -1))
            return true;
        return false;
    }
    
} 

