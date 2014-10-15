using UnityEngine;
using Task;

    public class TaskGenerator : MonoBehaviour 
    {
        private static TaskGenerator _obj;
        public GameObject Problem;

        Vector3 theNewPos = new Vector3(UnityEngine.Random.Range(200, 250), 1, UnityEngine.Random.Range(200, 250));
        private int p;
        private ProblemType problemType;

        private TaskGenerator()
        {
            // prevents instantiation from external entities
        }

        public static TaskGenerator GetObject() // instead of creating new operator, declare a method and that will create object and return it.
        {
            if(_obj != null) 
            {
                _obj = null;
            }

            _obj = new TaskGenerator();
            return _obj;
        }
        public void Generate(float playerKnowledge, ProblemType type)
        {
            for (int i = 0; i < 5; i++)
            {
                theNewPos = new Vector3(UnityEngine.Random.Range(200, 250), 1, UnityEngine.Random.Range(200, 250));
                Debug.Log("webrowenrower");

                float randomDifficulty = UnityEngine.Random.Range(playerKnowledge * 0.5f, playerKnowledge * 2.0f);

                Task.Task ProblemOne = new Task.Task(type, randomDifficulty);
                Instantiate(Problem, theNewPos, transform.rotation);
            }
        }    
    }

