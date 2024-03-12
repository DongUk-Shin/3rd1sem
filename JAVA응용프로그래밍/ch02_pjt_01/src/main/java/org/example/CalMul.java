package org.example;

public class CalMul implements ICalculator {
    @Override
    public int doOperation(int firstNum, int secondNum) {
        return firstNum * secondNum;
    }
}
