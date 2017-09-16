namespace _7.Military_Elite
{
    using System.Collections.Generic;
    using _7.Military_Elite.Models;

    public class MilitaryManager
    {
        public Private CreatePrivate(List<string> inputArgs)
        {
            var id = inputArgs[1];
            var firstName = inputArgs[2];
            var lastName = inputArgs[3];
            var salary = double.Parse(inputArgs[4]);
            var privateSoldier = new Private(id, firstName, lastName, salary);
            return privateSoldier;
        }

        public LeutenantGeneral CreateGeneral(List<string> inputArgs, List<Private> privates)
        {
            var id = inputArgs[1];
            var firstName = inputArgs[2];
            var lastName = inputArgs[3];
            var salary = double.Parse(inputArgs[4]);
            var leutenantGeneral = new LeutenantGeneral(id, firstName, lastName, salary);
            for (int i = 5; i < inputArgs.Count; i++)
            {
                var currentId = inputArgs[i];
                var currentPrivate = privates.Find(p => p.Id == currentId);
                leutenantGeneral.Privates.Add(currentPrivate);
            }
            return leutenantGeneral;
        }

        public Engineer CreaterEngineer(List<string> inputArgs)
        {
            var id = inputArgs[1];
            var firstName = inputArgs[2];
            var lastName = inputArgs[3];
            var salary = double.Parse(inputArgs[4]);
            var corps = inputArgs[5];
            var engineer = new Engineer(id, firstName, lastName, salary, corps);
            if (inputArgs.Count > 5)
            {
                for (int i = 6; i < inputArgs.Count; i += 2)
                {
                    var currentNPart = inputArgs[i];
                    var currentNHours = int.Parse(inputArgs[i + 1]);
                    var currentRepair = new Repair(currentNPart, currentNHours);
                    engineer.Repairs.Add(currentRepair);
                }
            }
            return engineer;
        }

        public Commando CreateCommando(List<string> inputArgs)
        {
            var id = inputArgs[1];
            var firstName = inputArgs[2];
            var lastName = inputArgs[3];
            var salary = double.Parse(inputArgs[4]);
            var corps = inputArgs[5];
            var commando = new Commando(id, firstName, lastName, salary, corps);
            if (inputArgs.Count > 5)
            {
                for (int i = 6; i < inputArgs.Count; i += 2)
                {
                    var currentCodeName = inputArgs[i];
                    var currentMissionState = inputArgs[i + 1];
                    var currentMission = new Mission(currentCodeName, currentMissionState);
                    if (currentMission.IsValid())
                    {
                        commando.Missions.Add(currentMission);
                    }
                }
            }
            return commando;
        }

        public Spy CreateSpy(List<string> inputArgs)
        {
            var id = inputArgs[1];
            var firstName = inputArgs[2];
            var lastName = inputArgs[3];
            var codeNumber = int.Parse(inputArgs[4]);
            var spy = new Spy(id, firstName, lastName, codeNumber);
            return spy;
        }

        public bool IsValidCorp(string corp)
        {
            if (corp == "Airforces" || corp == "Marines")
            {
                return true;
            }
            return false;
        }
    }
}
