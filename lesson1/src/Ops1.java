/**
 * 
 */

/**
 * @author mobix
 *
 */
public class Ops1 {
	public static void main(String[] args) {
		int i = 2;
		int j = 5;
		String s ="Udregning: 2+5 = ";
		System.out.println( s + i + j ); // 25 da i og j ikke er string konverteres de til chars og tilføjes
		System.out.println(i + " + " + j + " = " + i + j); //25 
		System.out.println(i + " + " + j + " = " + (i + j)); // 7 behandler deludtrykket i+j som  int udregning og konverterer
		
	}
}
