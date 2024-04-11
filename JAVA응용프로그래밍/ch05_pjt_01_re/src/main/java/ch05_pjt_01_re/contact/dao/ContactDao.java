package ch05_pjt_01_re.contact.dao;

import ch05_pjt_01_re.contact.ContactSet;

import java.util.HashMap;
import java.util.Map;

public class ContactDao {
    
    private Map<String, ContactSet> contactDB = new HashMap<>();
    
    public void insert(ContactSet contactSet) {
        contactDB.put(contactSet.getName(), contactSet);
        
    }
    
    public ContactSet select(String name) {
        return contactDB.get(name);
    }
    
    public Map<String, ContactSet> getContactDB() {
        return contactDB;
    }
    
}
