using System.Runtime.Serialization.Formatters;

namespace Task
{
    public class Task : IChance
    {
        private const double BasicChance = 0.80;//80%
        private const double BasicRewardPercent = 0.05;
        private const double SuperiorRewardPercent = 0.20;

        public Task(Type type, double knowledgeLevel)
        {
            this.TypeOfProblem = type;
            this.KnowledgeLevel = knowledgeLevel;


        }

        private Type TypeOfProblem { get; set; }
        private double KnowledgeLevel { get; set; }

        public double CalculateReward(double playerKnowledge)
        {
            double basicReward = BasicRewardPercent*this.KnowledgeLevel;

            if (playerKnowledge > this.KnowledgeLevel)
            {
                double superior = (this.KnowledgeLevel - playerKnowledge) * SuperiorRewardPercent;
            }

            return basicReward;
        }

        public double CalculateChanceToSolve(double playerKnowledge = 200.0)
        {
            TypeOfDifficult typeOfDifficult = GetTypeOfDifficult(this.KnowledgeLevel, playerKnowledge);

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

        private TypeOfDifficult GetTypeOfDifficult(double knowledgeLevel, double playerKnowledge)
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
    }
}
