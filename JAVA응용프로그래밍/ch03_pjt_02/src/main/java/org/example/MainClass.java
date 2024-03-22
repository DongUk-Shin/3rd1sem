package org.example;

import org.springframework.context.support.GenericXmlApplicationContext;

public class MainClass {
    public static void main(String[] args) {
//        TransportationWalk transportationWalk = new TransportationWalk();
//        transportationWalk.move();
        
        GenericXmlApplicationContext context
                = new GenericXmlApplicationContext("classpath:applicationContext.xml");
        
        TransportationWalk tWalk = context.getBean("tWalk", TransportationWalk.class);
        tWalk.move();
        context.close();
        
    }
}
