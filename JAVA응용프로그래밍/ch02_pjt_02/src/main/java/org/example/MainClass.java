package org.example;

public class MainClass {
    public static void main(String[] args) {
        
        MyCalculator calculator = new MyCalculator();
        calculator.calAdd(10, 5, new CalAdd());
        calculator.calSub(10, 5, new CalSub());
        calculator.calMul(10, 5, new CalMul());
        calculator.calDiv(10, 5, new CalDiv());
        

    }
}