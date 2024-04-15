public class ThreadExample {
    public static void main(String[] args) throws InterruptedException {
        
        long sum = 0;
        
        MyThread[] threads = new MyThread[10];
        
        for (int i = 0; i < 10; i++) {
            int start = i * (100000) + 1;
            int end = (i + 1) * (100000);
            threads[i] = new MyThread(start, end);
            threads[i].start();
        }
        
        for (int i = 0; i < 10; i++) {
            threads[i].join();
        }
        
        for (int i = 0; i < 10; i++) {
            sum += threads[i].getResult();
        }
        
        System.out.println("sum: " + sum);
    }
}

class MyThread extends Thread {
    private int start, end;
    private long result;
    
    public MyThread(int start, int end) {
        this.start = start;
        this.end = end;
    }
    
    @Override
    public void run() {
        long sum = 0;
        for (int i = start; i <= end; i++) {
            sum += i;
        }
        this.result = sum;
    }
    
    public long getResult() {
        return result;
    }
}
