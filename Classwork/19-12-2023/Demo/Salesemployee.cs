namespace hr{
    public class Salesemployee : WageEmployee{
        private double Incentive{get;set;}
        private double Target{get;set;}
        public Salesemployee():this(1,"dfs","sdf",5,500,200,300){

        }
        public Salesemployee(int id,string fname,string lname,int hrs,double rate,double Incentive,double Target):base(id,fname,lname,hrs,rate){
        this.Target=Target;
        this.Incentive=Incentive;
    }
    public override String ToString(){
        return base.ToString()+" "+Incentive+" "+Target;
    }
    }

}