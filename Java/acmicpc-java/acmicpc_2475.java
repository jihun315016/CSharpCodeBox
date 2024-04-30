// 2475 검증수

import java.util.Scanner;

class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int total = 0, num;

        for (int i = 0; i < 5; i++) {
            num = sc.nextInt();
            total = total + (num * num);
        }

        System.out.println(total % 10);
    }
}