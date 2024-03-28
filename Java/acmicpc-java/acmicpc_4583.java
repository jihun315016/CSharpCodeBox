// 4583 거울상 

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input, result;

        Map<String, String> map = new HashMap<String, String>();
        map.put("b", "d");
        map.put("d", "b");
        map.put("p", "q");
        map.put("q", "p");
        map.put("i", "i");
        map.put("o", "o");                
        map.put("v", "v");                
        map.put("w", "w");                
        map.put("x", "x");

        while (true) {
            input = sc.nextLine();

            // 자바 문자열 비교는 == 대신 equals 메서드를 사용한다.
            if (input.equals("#")) {
                break;
            }
            
            result = "";
            for(int i = input.length() - 1; i > -1; i--) {
                if (map.containsKey(String.valueOf(input.charAt(i)))) {
                    result = result + map.get(String.valueOf(input.charAt(i)));
                }
                else {
                    result = "INVALID";
                    break;
                }
            }

            System.out.println(result);
        }
    }
}