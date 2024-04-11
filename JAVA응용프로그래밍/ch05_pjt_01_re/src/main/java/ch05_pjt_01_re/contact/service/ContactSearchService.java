package ch05_pjt_01_re.contact.service;

import ch05_pjt_01_re.contact.ContactSet;
import ch05_pjt_01_re.contact.dao.ContactDao;
import org.springframework.beans.factory.annotation.Qualifier;

import javax.annotation.Resource;

public class ContactSearchService {
    
    @Resource
    //@Qualifier("usedDao")
    private ContactDao contactDao;
    
    /*
    public ContactSearchService() {
        System.out.println("Search 기본 생성자");
    }
    
    @Autowired
    public ContactSearchService(ContactDao contactDao) {
        System.out.println("contactDao = " + contactDao);
        this.contactDao = contactDao;
    }*/
    
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
