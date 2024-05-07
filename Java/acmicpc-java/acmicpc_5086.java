// 5086 배수와 약수

import java.util.Scanner;

class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int a, b;

        while (true) { 
            a = sc.nextInt();
            b = sc.nextInt();
            sc.nextLine();
            
            if (a == 0 && b == b) {
                break;
            }
            
            if (a % b == 0) {
                System.out.println("multiple");
            }
            else if (b % a == 0) {
                System.out.println("factor");
            }
            else {
                System.out.println("neither");
            }
        }
    }
}
