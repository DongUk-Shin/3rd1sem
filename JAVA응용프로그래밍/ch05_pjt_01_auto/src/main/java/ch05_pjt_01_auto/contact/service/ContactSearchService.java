package ch05_pjt_01_auto.contact.service;

import ch05_pjt_01_auto.contact.ContactSet;
import ch05_pjt_01_auto.contact.dao.ContactDao;
import org.springframework.beans.factory.annotation.Autowired;

public class ContactSearchService {
    
    
    private ContactDao contactDao;
    
    /*
    public ContactSearchService() {
        System.out.println("Search 기본 생성자");
    }
    
    @Autowired*/
    public ContactSearchService(ContactDao contactDao) {
        System.out.println("contactDao = " + contactDao);
        this.contactDao = contactDao;
    }
    
    public ContactSet searchContact(String name) {
        if (verify(name)) {
            return contactDao.select(name);  
        } else {
            System.out.println("Contact information is available");
        } 
        
        return null;
    }
    
    private boolean verify(String name) {
        ContactSet contactSet = contactDao.select(name);
        return contactSet != null ? true : false;
    }
    
    public void setContactDao(ContactDao contactDao) {
        this.contactDao = contactDao;
    }
}
