package ch06_pjt_01.ems.member.service;

import ch06_pjt_01.ems.member.Student;
import ch06_pjt_01.ems.member.dao.StudentDao;

public class StudentRegisterService {
    
    private StudentDao studentDao;
    
    public StudentRegisterService(StudentDao studentDao) {
        this.studentDao = studentDao;
    }
    
    public void register(Student student) {
        if (verify(student.getsNum())) {
            studentDao.insert(student);
        }
        else {
            System.out.println("The Student has already registered");
            
        }
    }
    
    private boolean verify(String sNum) {
        Student student = studentDao.select(sNum);
        return student == null ? true : false;
    }
}
