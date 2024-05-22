public class Bankers {
    static int N; // 프로세스 수
    static int M; // 자원 종류 수
    static int[] Available;
    static int[][] Max;
    static int[][] Allocation;
    static int[][] Need;
    
    static void calNeed() {
        for (int i = 0; i < N; i++) {
            for (int j = 0; j < M; j++) {
                Need[i][j] = Max[i][j] - Allocation[i][j];
            }
        }
    }
    
    static boolean isSafety() {
        // Finish 초기화 (크기 = 프로세스 수)
        boolean[] Finish = new boolean[N];
        int[] safeSequence = new int[N];
        
        // Work 배열 초기화 (크기 = 자원)
        int[] Work = new int[M];
        for (int i = 0; i < M; i++)
            Work[i] = Available[i];
        
        int counter = 0;
        while (counter < N) {
            boolean safeFlag = false;
            
            // 모든 프로세스에 대해 반복
            for (int i = 0; i < N; i++) {
                if (!Finish[i]) { // i번째 프로세스가 완료되지 않았으면
                    int j;
                    
                    for (j = 0; j < M; j++)
                        if (Need[i][j] > Work[j]) // 현재 가용 가능한 자원보다 Need가 큰지 확인
                            break;
                    
                    // 현재 프로세스의 모든 Need가 충족된 것.
                    if (j == M) {
                        for (int k = 0; k < M; k++)
                            Work[k] += Allocation[i][k];
                        
                        safeSequence[counter++] = i;
                        
                        Finish[i] = true;
                        safeFlag = true;
                    }
                }
            }
            
            if (!safeFlag) {
                System.out.print("시스템은 자원 부족으로 안전하지 않음.");
                return false;
            }
        }
        
        System.out.print("시스템은 안전한 상태 : ");
        for (int i = 0; i < N; i++)
            System.out.print("P" + safeSequence[i] + " ");
        System.out.println();
        return true;
    }
    
    
    static boolean resourceRequest(int processNum, int[] request) {
        System.out.println("\n[자원 요청 알고리즘]");
        System.out.print("프로세스 " + processNum + "번에 대해 ( ");
        for (int i : request) {
            System.out.print(i + " ");
        }
        System.out.println(") 요청");
        
        
        // 요청이 가능한지 확인 (요청이 Need와 Available 범위 내에 있는지)
        for (int i = 0; i < M; i++) {
            if (request[i] > Need[processNum][i]) {
                System.out.println("Error: 요청이 필요 자원보다 큼.");
                return false;
            }
            if (request[i] > Available[i]) {
                System.out.println("Error: 요청이 가용 자원보다 큼.");
                return false;
            }
        }
        
        // 임시로 자원을 할당, 시스템이 안전한지 확인.
        for (int i = 0; i < M; i++) {
            Available[i] -= request[i];
            Allocation[processNum][i] += request[i];
            Need[processNum][i] -= request[i];
        }
        
        boolean safe = isSafety();
        
        if (!safe) { // 원상 복구
            for (int i = 0; i < M; i++) {
                Available[i] += request[i];
                Allocation[processNum][i] -= request[i];
                Need[processNum][i] += request[i];
            }
            System.out.println("요청 거부");
            return false;
        }
        
        System.out.println("요청 승인");
        return true;
    }
    
    public static void main(String[] args) {
        N = 5; // 프로세스 수
        M = 4; // 자원 종류 수
        
        Allocation = new int[][]{
                {0, 0, 1, 2},
                {1, 0, 0, 0},
                {1, 3, 5, 4},
                {0, 6, 3, 2},
                {0, 0, 1, 4}
        };
        Max = new int[][]{
                {0, 0, 1, 2},
                {1, 7, 5, 0},
                {2, 3, 5, 6},
                {0, 6, 5, 2},
                {0, 6, 5, 6}
        };
        
        Available = new int[]{1, 5, 2, 0};
        
        Need = new int[N][M];
        calNeed(); //Need 계산
        
        System.out.println("[최초 상태에 대한 안정성 테스트]");
        isSafety(); //안전성 알고리즘
        
        int[] request = {0, 4, 2, 0};
        resourceRequest(1, request); //자원 요청 알고리즘
    }
}
