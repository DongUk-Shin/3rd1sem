package org.example;

public class MyCalculator {
    public void calAdd(int fNum, int sNum, CalAdd calAdd) {
        int result = calAdd.doOperation(fNum, sNum);
        System.out.println("result = " + result);
    }
    
    public void calSub(int fNum, int sNum, CalSub calSub) {
        int result = calSub.doOperation(fNum, sNum);
        System.out.println("result = " + result);
    }
    
    public void calMul(int fNum, int sNum, CalMul calMul) {
        int result = calMul.doOperation(fNum, sNum);
        System.out.println("result = " + result);
        
    }
    public void calDiv(int fNum, int sNum, CalDiv calDiv) {
        int result = calDiv.doOperation(fNum, sNum);
        System.out.println("result = " + result);
        
    }
}
