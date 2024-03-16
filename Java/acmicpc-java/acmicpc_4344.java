// 4344 평균은 넘겠지

import java.util.Arrays;
import java.util.Scanner;

class acmicpc_4344 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] sArr;
        int[] iArr;
        double avg;
        int k;
        String result;

        // nextInt()는 정수 입력만 처리하고 줄바꿈(엔터키)은 처리하지 않는다.
        // 그래서 nextLine() 메서드를 한 번 호출하여 줄바꿈을 처리한다.
        int t = sc.nextInt();
        sc.nextLine();

        for (int i = 0; i < t; i++) {
            sArr = sc.nextLine().split(" ");
            avg = 0;
            
            iArr = new int[sArr.length - 1];
            for(int j = 1; j < sArr.length; j++) {
                iArr[j - 1] = Integer.parseInt(sArr[j]);
            }

            avg = (double)Arrays.stream(iArr).sum() / iArr.length;
            k = 0;
            for(int item : iArr) {
                if (item > avg) {
                    k = k + 1;
                }
            }
           
            result = String.format("%.3f%%", (double)k / iArr.length * 100);
            System.out.println(result);
        }
    }
}