package ch06_pjt_01.ems;

import ch06_pjt_01.ems.configuration.MemberConfig;
import ch06_pjt_01.ems.configuration.MemberConfig1;
import ch06_pjt_01.ems.configuration.MemberConfig2;
import ch06_pjt_01.ems.configuration.MemberConfig3;
import ch06_pjt_01.ems.member.Student;
import ch06_pjt_01.ems.member.service.*;
import ch06_pjt_01.ems.utils.InitSampleData;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;

public class MainClassUseConfigs {
    
    
    
    public static void main(String[] args) {
        AnnotationConfigApplicationContext context = new AnnotationConfigApplicationContext(MemberConfig1.class, MemberConfig2.class, MemberConfig3.class);
        
        InitSampleData initSampleData = context.getBean("initSampleData", InitSampleData.class);
        
        String[] sNums = initSampleData.getsNums();
        String[] sIds = initSampleData.getsIds();
        String[] sPws = initSampleData.getsPws();
        String[] sNames = initSampleData.getsNames();
        int[] sAges = initSampleData.getsAges();
        char[] sGenders = initSampleData.getsGenders();
        String[] sMajors = initSampleData.getsMajors();
        
        StudentRegisterService registerService = context.getBean("studentRegisterService", StudentRegisterService.class);
        
        for (int i = 0; i < sNums.length; i++) {
            registerService.register(new Student(sNums[i], sIds[i], sPws[i], sNames[i], sAges[i], sGenders[i], sMajors[i]));
            
        }
        PrintStudentInformationService printStudentInformationService = context.getBean("printStudentInformationService", PrintStudentInformationService.class);
        printStudentInformationService.printStudentsInfo();
        
        // 학생 등록
        registerService = context.getBean("studentRegisterService", StudentRegisterService.class);
        registerService.register(new Student("hbs006", "deer", "p0006", "melissa", 26, 'w', "Music"));
        
        printStudentInformationService.printStudentsInfo(); // 학생 리스트
        
        
        // 학생 출력
        StudentSelectService selectService = context.getBean("studentSelectService", StudentSelectService.class);
        Student selectedstudent = selectService.select("hbs006");
        
        System.out.println("STUDENT START ------------------");
        System.out.print("sNum:" + selectedstudent.getsNum() + "\t");
        System.out.print("|sId:" + selectedstudent.getsId() + "\t");
        System.out.print("|sPw:" + selectedstudent.getsPw() + "\t");
        System.out.print("|sName:" + selectedstudent.getsName() + "\t");
        System.out.print("|sAge:" + selectedstudent.getsAge() + "\t");
        System.out.print("|sGender:" + selectedstudent.getsGender() + "\t");
        System.out.println("|sMajor:" + selectedstudent.getsMajor());
        System.out.println("END ----------------------------");
        
        // 학생 수정
        StudentModifyService modifyService = context.getBean("studentModifyService", StudentModifyService.class);
        modifyService.modify(new Student("hbs006", "pig", "p0066", "melissa", 27, 'w', "Computer"));
        
        printStudentInformationService.printStudentsInfo(); // 학생 리스트
        
        // 학생 삭제
        StudentDeleteService deleteService = context.getBean("studentDeleteService", StudentDeleteService.class);
        deleteService.delete("hbs005");
        
        printStudentInformationService.printStudentsInfo(); // 학생 리스트
        
        // 시스템 정보
        EMSInformationService emsInformationService = context.getBean("eMSInformationService", EMSInformationService.class);
        emsInformationService.printEMSInformation();
        
        context.close();
        
        
    }
    
}
