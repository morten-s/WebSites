
public class Borrower extends Person {
    private String[] interests;         
    private String email;
    private boolean newsletter;
    
    public Borrower(String name, Cprno cpr, String address, boolean newsletter, String email, String[] interests) {
        super(name, cpr, address);
        if (interests.length <=3){
        	this.interests = interests;
        }
        this.email = email;
    }
 
    public Boolean hasInterest() {
    	if(interests.length > 0){
    		return true;
    	}else{
    		return false;
    	}
    }
    public String showInterests() {
    	String str;
    	str = "";
        for (int i = 0; i < interests.length; i++){
        	str += this.interests[i].toString()+" ";
        }
        return str;
    }   
    public String getEmail() {
        return this.email;
    }
    public Boolean wantsNewsletter() {
        return this.newsletter;
    }
 
 
    
    public String toString() {
        String s = String.format("%60s %20s %2s", this.showInterests(), this.getEmail(), wantsNewsletter());
        return s;
    }
    
    /**
     * @param args
     */
    public static void main(String[] args) {
        Cprno c = new Cprno(2511450007L);
        String str[] ={"jazz", "techno","klassisk"};
        Person l1 = new Borrower("Niels Muller Larsen", c, "Sønderhøj 30", true, "nml@eaa.dk", str);
        System.out.println(l1);
    }

}