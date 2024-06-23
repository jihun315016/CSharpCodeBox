// 5026 박사 과정

import java.util.Scanner;

class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        String exp;
        String[] expArr;

        sc.nextLine();
        for (int i = 0; i < n; i++) {
            exp = sc.nextLine();
            if (exp.contains("+")) {
                expArr = exp.split("\\+");
                System.out.println(Integer.valueOf(expArr[0]) + Integer.valueOf(expArr[1]));
            }
            else {
                System.out.println("skipped");
            }
        }
    }
}
