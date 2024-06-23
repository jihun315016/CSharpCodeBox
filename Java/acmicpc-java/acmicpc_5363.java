// 5363 요다

import java.util.Scanner;

class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        String[] arr;

        sc.nextLine();
        for (int i = 0; i < n; i++) {
            arr = sc.nextLine().split(" ");
            
            for (int j = 0; j < arr.length; j++) {
                System.out.print(arr[(j + 2) % arr.length] + " ");
            }
            System.out.println();
        }
    }
}
