import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class CalGUI extends JFrame implements ActionListener  {
    
    Parser p = new Parser();
    
    private final JTextField ExpTextField; //수식이 입력될 텍스트 필드
    private final JTextField ResultTextField; //결과를 보여줄 텍스트 필드
    
    public CalGUI() {
        setTitle("계산기");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setSize(350, 580);
        getContentPane().setBackground(Color.GRAY);
        
        // EXP 필드 패널
        JPanel expPanel = new JPanel(new BorderLayout());
        expPanel.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10)); // 마진 설정
        ExpTextField = new JTextField();
        ExpTextField.setEditable(false);
        ExpTextField.setHorizontalAlignment(SwingConstants.RIGHT);
        ExpTextField.setPreferredSize(new Dimension(300, 75));
        ExpTextField.setFont(new Font("Arial", Font.BOLD, 30));
        ExpTextField.setBorder(BorderFactory.createLineBorder(Color.BLACK)); // 테두리 설정
        ExpTextField.setText("");
        expPanel.add(ExpTextField, BorderLayout.CENTER);
        
        // Result 필드 패널
        JPanel resultPanel = new JPanel(new BorderLayout());
        resultPanel.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10)); // 마진 설정
        ResultTextField = new JTextField();
        ResultTextField.setEditable(false);
        ResultTextField.setHorizontalAlignment(SwingConstants.RIGHT);
        ResultTextField.setPreferredSize(new Dimension(300, 75));
        ResultTextField.setFont(new Font("Arial", Font.BOLD, 30));
        ResultTextField.setBorder(BorderFactory.createLineBorder(Color.BLACK)); // 테두리 설정
        ResultTextField.setText("");
        resultPanel.add(ResultTextField, BorderLayout.CENTER);
        
        // 버튼 생성
        String[] buttonLabels = {
                "CE", "Del", "", "=",
                "x²", "√", "(", ")",
                "7", "8", "9", "*",
                "4", "5", "6", "÷",
                "1", "2", "3", "-",
                "", "0", ".", "+"
        };
        JPanel buttonPanel = new JPanel(new GridLayout(6, 4));
        for (String label : buttonLabels) {
            JButton button = new JButton(label);
            button.addActionListener(this);
            button.setFont(new Font("Arial", Font.BOLD, 20)); // 폰트 변경
            button.setBackground(Color.LIGHT_GRAY); // 배경색 변경
            
            
            
            buttonPanel.add(button);
        }
        buttonPanel.setPreferredSize(new Dimension(200, 350));
        
        // ResultField와 버튼 패널을 담을 패널 생성
        JPanel ExpResultPanel = new JPanel(new BorderLayout());
        ExpResultPanel.add(resultPanel, BorderLayout.SOUTH);
        ExpResultPanel.add(expPanel, BorderLayout.NORTH);
        
        // 전체 레이아웃 설정
        setLayout(new BorderLayout());
        add(buttonPanel, BorderLayout.SOUTH);
        add(ExpResultPanel, BorderLayout.NORTH);
    }
    
    @Override
    public void actionPerformed(ActionEvent e) {
        String command = e.getActionCommand();
        
        switch (command) {
            case "Del" -> {
                String currentText = ExpTextField.getText();
                if (!currentText.isEmpty()) {
                    ExpTextField.setText(currentText.substring(0, currentText.length() - 1));
                }
            }
            case "CE" -> {
                ExpTextField.setText("");
                ResultTextField.setText("");
            }
            case "√" -> {
                String expression = ExpTextField.getText();
                expression = Double.toString(Math.sqrt(Double.parseDouble(expression)));
                ResultTextField.setText(expression);
                
            }
            case "x²" -> {
                String expression = ExpTextField.getText();
                expression = Double.toString(Math.pow(Double.parseDouble(expression), 2));
                ResultTextField.setText(expression);
                
            }
            case "=" -> {
                ResultTextField.setFont(new Font("Arial", Font.BOLD, 30));
                String expression = ExpTextField.getText();
                
                try {
                    double result = p.evaluate(expression);
                    ResultTextField.setText(Double.toString(result));
                } catch (ParserException ex) {
                    ResultTextField.setText("" + ex);
                }
            }
            default -> ExpTextField.setText(ExpTextField.getText() + command);
        }
    }
    
    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            CalGUI calculator = new CalGUI();
            calculator.setVisible(true);
            
        });
    }
}
