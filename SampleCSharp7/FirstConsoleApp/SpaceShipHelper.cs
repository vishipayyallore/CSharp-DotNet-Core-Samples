using ClassesAndGenerics;

namespace FirstConsoleApp
{
    public class SpaceShipHelper
    {

        public SpaceShipHelper PerformSpaceShipActions()
        {
            var spaceShip = new SpaceShip();

            spaceShip
                .ControlBridge()
                .CrewQuarters(1500)
                .EngineRoom(2)
                .MedicalBay(350)
                .TeleportationRoom();

            return this;
        }

        public SpaceShipHelper PerformDestroyerActions()
        {
            var destroyer = new Destroyer();
            destroyer
                .Armory(6)
                .WarRoom()
                .WarSpecialists(1)
                .ControlBridge()
                .CrewQuarters(2200)
                .EngineRoom(4)
                .MedicalBay(800) 
                .TeleportationRoom();

            return this;
        }

        public SpaceShipHelper PerformAnnihilatorActions()
        {
            var annihilator = new Annihilator();
            annihilator
                .PlanetDestructionCapability()
                .TractorBeam()
                .Armory(12)
                .WarRoom()
                .WarSpecialists(2)
                .ControlBridge()
                .CrewQuarters(4500)
                .EngineRoom(7)
                .MedicalBay(3500)
                .TeleportationRoom();
            return this;
        }

    }
}