package org.example;

public class CalAdd implements ICalculator{
    @Override
    public int doOperation(int fNum, int sNum) {
        return fNum + sNum;
    }
}
