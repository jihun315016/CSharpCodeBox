// 9093 단어 뒤집기 

import java.util.Scanner;

class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String[] sArr;
        StringBuffer sb;
        int t = sc.nextInt();
        sc.nextLine();

        for (int i = 0; i < t; i++) {
            sArr = sc.nextLine().split(" ");
            for (String s : sArr) {
                sb = new StringBuffer(s);
                System.out.print(sb.reverse().toString() + " ");
            }
        }

        System.out.println();
    }
}