// 2884 알람 시계

import java.util.Scanner;

class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int hour = sc.nextInt();
        int minute = sc.nextInt();

        minute = minute - 45;
        if (minute < 0) {
            minute = minute + 60;
            hour = hour - 1;

            if (hour < 0) {
                hour = 23;
            }
        }

        System.out.println(hour + " " + minute);
    }
}
