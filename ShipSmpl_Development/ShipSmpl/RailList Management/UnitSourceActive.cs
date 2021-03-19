
namespace ShipSmpl
{
    public class UnitSourceActive
    {
        public string Field { get; set; }
        public int MiniUnitId { get; set; }
        public int UnitSourceId { get; set; }

        public UnitSourceActive()
        {
        }

        public UnitSourceActive(string _Field, int _MiniUnitId, int _UnitSourceId)
        {
            Field = _Field;
            MiniUnitId = _MiniUnitId;
            UnitSourceId = _UnitSourceId;
        }
    }
}