package realShnack;
import classicnet.*;
import java.awt.Color;
import java.awt.Graphics;
import java.util.ArrayList;
import java.util.Random;

public class Snake implements Comparable<Snake>{
	class block{
		int x,y;
		block(int a,int b){
			x=a;y=b;
		}
	}
	int x,y,xv,yv,score,lfs;//lastfoodscore
	ArrayList<block> blocks;
	block food;
	Network brain;
	Random r;
	double discovery;
	
	public Snake() {
		r=new Random();
		discovery=0;
		score=0;lfs=0;
		x=10;y=10;
		x=r.nextInt((Game.w-Game.step)/Game.step);y=r.nextInt((Game.h-Game.step)/Game.step);
		blocks=new ArrayList<block>();
		blocks.add(new block(x,y));
		xv=1;yv=0;
		brain=new Network(9,3,new int[] {10}) ;
		food=new block(r.nextInt((Game.w-Game.step)/Game.step),r.nextInt((Game.h-Game.step)/Game.step));
	}
	public int length() {
		return blocks.size();
	}
	public void tick() {
		//System.out.println("snake tick");
		score++;
		x+=xv;y+=yv;
		blocks.add(new block(x,y));
		
		if(x==food.x&&y==food.y) {
			score+=500;
			lfs=score;
			boolean bo=true; 
			outerloop:
			do {
			for(block b:blocks) {//////////////////////avoid spawning food on body
				if(b.x==food.x&&b.y==food.y) {
				food=new block(r.nextInt((Game.w-Game.step)/Game.step),r.nextInt((Game.h-Game.step)/Game.step));
				continue outerloop;
				}
			}
			bo=false;
			}while(bo);
		}
		else
			blocks.remove(0);
	}
	public void think() {
		double max;
		
		brain.eval(getenv());
		max=Math.max(brain.out[0].val, brain.out[1].val);
		max=Math.max(max, brain.out[2].val);

		if(r.nextInt(10)<discovery) {
			max=brain.out[r.nextInt(2)].val;
			discovery-=0.01;}

		if(max==brain.out[2].val)
			return;

		if(max==brain.out[1].val) {
			switch(yv+2*xv){
		case -1:setDir("left");break;
		case 1:setDir("right");break;
		case -2:setDir("down");break;
		case 2:setDir("up");break;
			}
			return;}

			switch(yv+2*xv){
				case -1:setDir("right");break;
				case 1:setDir("left");break;
				case -2:setDir("up");break;
				case 2:setDir("down");break;
		}

	}
	public void render(Graphics g) {
		g.setColor(Color.white);
		block b;
		for(int i=0;i<length();i++) {
			b=blocks.get(i);
			g.fillRect(b.x*Game.step, b.y*Game.step, Game.step, Game.step);
		}
		g.setColor(Color.red);
		g.fillRect(food.x*Game.step, food.y*Game.step,Game.step,Game.step);
	}
	boolean dead() {
		if(x>=Game.w/Game.step||x<0||y>=Game.h/Game.step||y<0)
			return true;
		for(int i=0;i<blocks.size()-1;i++) {
			if(x==blocks.get(i).x&&y==blocks.get(i).y)
				return true;
		}
		if(lfs+5*(Game.w/Game.step)<score)
			return true;
		return false;
	}
	public int[][] getMatrix(int x,int y){
		int[][] res=new int[x][y];
		for(int i=x-1;i>=0;i--)
			for(int j=y-1;j>=0;j--) {
				//System.out.println(i+" "+j);
				res[i][j]=1;
			}
				
		for(int i=blocks.size()-1;i>=0;i--) {
			//System.out.println(i+" "+blocks.get(i).x+" "+blocks.get(i).y);
			res[blocks.get(i).x][blocks.get(i).y]=1;
		}
			
		res[food.x][food.y]=0;
		return res;
	}
	
	public void setDir(String s) {
		switch (s){
		case "up":if(xv!=0&&yv!=-1) {xv=0;yv=-1;}break;
		case "down":if(xv!=0&&yv!=1) {yv=1;xv=0;}break;
		case "right":if(xv!=1&&yv!=0) {yv=0;xv=1;}break;
		case "left":if(xv!=-1&&yv!=0) {yv=0;xv=-1;}break;
		}
	}
	public Snake evolve() {
		Snake s=new Snake();
		s.brain=this.brain.clone();
		s.brain.evolve();
		return s;
	}
	public double[] getenv() {
		int dim=Game.w/Game.step;
		//System.out.println("getenv");
		double[] res=new double[3*3];//range of 5 blocks     3 wall   3 food   3 body
		block[] resPos=new block[3];
		//res[0]=right res[1]=front res[2]=left
		
		for(int i=res.length-1;i>=0;i--)
				res[i]=0;
		for(int i=1;i<=5;i++) {

			resPos[0]=new block(x-i*yv,y+i*xv);
			resPos[1]=new block(x+i*xv, y+i*yv);
			resPos[2]=new block(x+i*yv, y-i*xv);

			i--;
			if(res[0]==0) {
		if(resPos[0].x<-1||resPos[0].y<-1||resPos[0].x>dim||resPos[0].y>dim)
			res[0]=1.0-0.25*i;	}
			if(res[1]==0) {
		if(resPos[1].x<-1||resPos[1].y<-1||resPos[1].x>dim||resPos[1].y>dim)
			res[1]=1.0-0.25*i;}
			if(res[2]==0) {
		if(resPos[2].x<-1||resPos[2].y<-1||resPos[2].x>dim||resPos[2].y>dim) 
			res[2]=1.0-0.25*i;}

		if(food.x-yv==resPos[0].x&&food.y+xv==resPos[0].y)///right
			res[3]=1-0.25*i;
		if(food.x-yv==resPos[1].x&&food.y+xv==resPos[1].y)///front
			res[4]=1-0.25*i;
		if(food.x-yv==resPos[2].x&&food.y+xv==resPos[2].y)///left
			res[5]=1-0.25*i;

		for(block b:blocks) {
			if(b.x==resPos[0].x&&b.y==resPos[0].y)///right
				res[6]=1-0.25*i;
			if(b.x==resPos[1].x&&b.y==resPos[1].y)///front
				res[7]=1-0.25*i;
			if(b.x==resPos[2].x&&b.y==resPos[2].y)///left
				res[8]=1-0.25*i;
		}
		i++;
		}
			return res;
	}

	public int compareTo(Snake s) {
		// TODO Auto-generated method stub
		return score-s.score;
	}
	public String getDir() {
		if(xv==0) {
			if(yv==1)
				return "down";
			return "up";
			}
		if(xv==1)
			return "right";
		return "left";
	}
}
