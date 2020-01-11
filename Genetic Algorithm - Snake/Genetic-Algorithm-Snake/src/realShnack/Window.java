package realShnack;
import java.awt.Canvas;
import java.awt.Dimension;

import javax.swing.JFrame;
public class Window extends Canvas{

	private static final long serialVersionUID = 9034494958129720942L;
	JFrame frame;
	public Window(int width,int height,String title,Game game) {
		frame=new JFrame(title);
		frame.setPreferredSize(new Dimension((int)(width+0.1*width),(int)(height+0.2*height)));
		//frame.setMaximumSize(new Dimension(width,height));
		frame.setMinimumSize(new Dimension((int)(width+0.1*width),(int)(height+0.2*height)));
		frame.setDefaultCloseOperation(3);
		frame.setResizable(true);
		frame.setLocationRelativeTo(null);
		frame.add(game);
		frame.setVisible(true);
		if(game.autostep)
			game.start();
		
	}
	public void setSize(int width,int height) {
		frame.setPreferredSize(new Dimension((int)(width+0.1*width),(int)(height+0.2*height)));
		//frame.setMaximumSize(new Dimension(width,height));
		frame.setMinimumSize(new Dimension((int)(width+0.1*width),(int)(height+0.2*height)));
	}
}

