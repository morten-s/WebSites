/**
 * 
 */

/**
 * @author mobix
 *
 */
public class WordPlay {
	private String str;
	
	public WordPlay(String str) {
		this.str = str;
		// TODO Auto-generated constructor stub
	}

	public char first(){
		return str.charAt(0);
	}
	public char last(){
		return str.charAt(str.length()-1);
	}
	public String middle(){
		return str.substring(1, str.length()-1);
	}
	
    public Boolean isPalindrom() {
    	if (this.str.length() <= 2 && this.last() == this.first()){
    		return true;
    	}
        if (this.last() == this.first()){ 
        	WordPlay wp = new WordPlay(this.middle());
        	if(wp.isPalindrom() == true){
        		return true;
        	}
        }
        return false;
        
    }

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		WordPlay wp = new WordPlay("kkkkkkkkkkrarkkkkkkkkkk");
		System.out.println(wp.isPalindrom());
	}

}
