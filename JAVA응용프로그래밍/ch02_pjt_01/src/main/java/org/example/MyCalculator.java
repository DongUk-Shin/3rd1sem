package org.example;

public class MyCalculator {
    public void calAdd(int fNum, int sNum) {
        ICalculator calculator = new CalAdd();
        int result = calculator.doOperation(fNum, sNum);
        System.out.println("result = " + result);
    }
    
    public void calSub(int fNum, int sNum) {
        ICalculator calculator = new CalSub();
        int result = calculator.doOperation(fNum, sNum);
        System.out.println("result = " + result);
    }
    
    public void calMul(int fNum, int sNum) {
        ICalculator calculator = new CalMul();
        int result = calculator.doOperation(fNum, sNum);
        System.out.println("result = " + result);
        
    }
    public void calDiv(int fNum, int sNum) {
        ICalculator calculator = new CalDiv();
        int result = calculator.doOperation(fNum, sNum);
        System.out.println("result = " + result);
        
    }
}
