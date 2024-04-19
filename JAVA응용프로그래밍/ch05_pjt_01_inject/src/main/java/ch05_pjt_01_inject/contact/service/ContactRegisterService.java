package ch05_pjt_01_inject.contact.service;

import ch05_pjt_01_inject.contact.ContactSet;
import ch05_pjt_01_inject.contact.dao.ContactDao;

import javax.annotation.Resource;
import javax.inject.Inject;
import javax.inject.Named;

public class ContactRegisterService {
    
    private ContactDao contactDao;
    
    public ContactRegisterService() {
        System.out.println("Register 기본 생성자");
    }
    
    @Inject
    @Named("contactDao1")
    public ContactRegisterService(ContactDao contactDao) {
        System.out.println("contactDao = " + contactDao);
        this.contactDao = contactDao;
    }
    
    
    public void register(ContactSet contactSet) {
        String name = contactSet.getName();
        if (verify(name)) {
            contactDao.insert(contactSet);
        } else {
            System.out.println("The name has already registered");
        }
    }
    
    private boolean verify(String name) {
        ContactSet contactSet = contactDao.select(name);
        return contactSet == null ? true : false;
    }
    
    /*public void serWordDao(ContactDao contactDao) {
        this.contactDao = contactDao;
    }*/
}
