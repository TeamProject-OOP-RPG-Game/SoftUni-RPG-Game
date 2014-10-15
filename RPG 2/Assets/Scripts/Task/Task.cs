namespace Task {

	using UnityEngine;
	using System.Collections;

	public class Task : MonoBehaviour {

		private const double BasicChance = 0.80;//80%
		private const double BasicRewardPercent = 0.05;
		private const double SuperiorRewardPercent = 0.20;
		
		public Task(ProblemType type, double knowledgeLevel)
		{
			this.TypeOfProblem = type;
			this.KnowledgeLevel = knowledgeLevel;
		}
		
		public ProblemType TypeOfProblem { get; private set; }
		public double KnowledgeLevel { get; private set; }
		
		public double CalculateReward(double playerKnowledge)
		{
			double basicReward = BasicRewardPercent*this.KnowledgeLevel;
			
			if (playerKnowledge > this.KnowledgeLevel)
			{
				double superior = (this.KnowledgeLevel - playerKnowledge) * SuperiorRewardPercent;
			}
			
			return basicReward;
		}
		
		public double CalculateChanceToSolve(double playerKnowledge)
		{
			TypeOfDifficult typeOfDifficult = GetTypeOfDifficulty(this.KnowledgeLevel, playerKnowledge);
			
			double chance = 0;
			if (typeOfDifficult == TypeOfDifficult.Easy)
			{
				chance = (((playerKnowledge - this.KnowledgeLevel) / playerKnowledge) * 0.25) + BasicChance;
			}
			else if (typeOfDifficult == TypeOfDifficult.Medium)
			{
				chance = BasicChance - (((this.KnowledgeLevel - playerKnowledge) / playerKnowledge) * 0.5);
			}
			else
			{
				chance = BasicChance - ((((this.KnowledgeLevel - playerKnowledge) / playerKnowledge) * 0.5) +
				                        (((this.KnowledgeLevel - playerKnowledge * 1.5) / playerKnowledge) * 0.5));
			}
			
			return chance;
		}
		
		private TypeOfDifficult GetTypeOfDifficulty(double knowledgeLevel, double playerKnowledge)
		{
			double differenceCoefficent = knowledgeLevel / playerKnowledge;
			
			if (differenceCoefficent > 1.5)
			{
				return TypeOfDifficult.Hard;
			}
			
			if (differenceCoefficent > 1)
			{
				return TypeOfDifficult.Medium;
			}
			
			return TypeOfDifficult.Easy;
		}

		// Use this for initialization
		void Start () {
		    
		}
		
		// Update is called once per frame
		void Update () {
		
		}
	}
}
