package org.example;

public class CalAssembler {
    MyCalculator calculator;
    CalAdd calAdd;
    CalSub calSub;
    CalMul calMul;
    CalDiv calDiv;
    
    public CalAssembler() {
        this.calculator = new MyCalculator();
        this.calAdd = new CalAdd();
        this.calSub = new CalSub();
        this.calMul = new CalMul();
        this.calDiv = new CalDiv();
        
        assemble();
    }
    
    public void assemble() {
        calculator.calculate(5, 10, calAdd);
        calculator.calculate(5, 10, calSub);
        calculator.calculate(5, 10, calMul);
        calculator.calculate(5, 10, calDiv);
        
        
    }
}
