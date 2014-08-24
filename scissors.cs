using System;

class Game
{
	public string move;
    public int[] scores;
	public bool condition;
	public int rounds;
    public int totalScore;
	
	
	public Game(int roundsIn)
	{
		string move=null;
		scores=new int[roundsIn];
		rounds=roundsIn;
		totalScore=0;
	}
	
	public void Move(string moveIn)
	{
		move=moveIn;
	}

    public string returnMove()
    {

        return this.move;

    }

    public void setScore(int score,int round)
    {
        scores[round]=score;
    }

	
	public bool Winner(string move2)
	{
		if(move=="r")
		{
			if(move2=="s")
			{
				condition=true;
            }		
            
		}
		
		else if(move=="p")
		{
			if(move2=="r")
			{
				condition=true;
			}
            
	    }
		
		else if(move=="s")
		{
			if(move2=="p")
			{
				condition=true;
			}
            
	    }

        else
		{
			condition=false;
		}
		
		return condition;
		
	}

    public void countTotal()
    {
        for(int i=0;i<scores.Length;i++)
        {
            totalScore=totalScore+scores[i];


        }

    
	}
	
	public int returnTotal()
	{
		return totalScore;
	
	
	}
	

    
	
	public int Rounds()
	{
		return rounds;
	}
		
}

class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter how many rounds do you want to play");
		string roundsIn=Console.ReadLine();
		int rounds=int.Parse(roundsIn);
		Game player= new Game(rounds);
		Game computer=new Game(rounds);
		Console.WriteLine("r=rock, p=paper, s=scissor");
		Random generator=new Random();
		string comMove=null;
				
		for(int i=0;i<player.Rounds();i++)
		{
			Console.WriteLine("Enter your move for this round");
			string input=Console.ReadLine();
			player.Move(input);
		
			int computerMove=generator.Next(0,2);
			if(computerMove==0)
			{
				comMove="r";
			}
			
			else if(computerMove==1)
			{
				comMove="p";
			}
			
			else
			{
				comMove="s";
			}
			
			computer.Move(comMove);
			
			if(player.Winner(comMove))
			{
				Console.WriteLine("You win this round");
				player.setScore(2,i);
				computer.setScore(0,i);
			}
			
			else
			{
				if(input==comMove)
				{
					Console.WriteLine("The round is a tie");
					computer.setScore(1,i);
					player.setScore(1,i);
				}
				
				else
				{
					Console.WriteLine("Computer wins this round");
					computer.setScore(2,i);
					player.setScore(0,i);
				
				}
				
			}
				
				
			
		}
		
		player.countTotal();
		computer.countTotal();
		
		if(player.returnTotal()>computer.returnTotal())
		{
			Console.WriteLine("You have won the game");
		}
		
		else
		{
			Console.WriteLine("Computer has won the game");
		}
		
		
	}
		
}

			
			
		
		
        
		
