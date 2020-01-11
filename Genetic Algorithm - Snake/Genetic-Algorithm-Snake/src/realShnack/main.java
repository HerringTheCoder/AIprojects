package realShnack;

public class main {

	public static void main(String[] args) {
			Game g=new Game();
			if(g.autostep==false) {
				g.addMouseListener(new Adapter(g));
				g.step();
			}
	}
}
