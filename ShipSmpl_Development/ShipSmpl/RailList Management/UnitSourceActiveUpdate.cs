
namespace ShipSmpl
{
    public class UnitSourceActiveUpdate
    {
        public string Field { get; set; }
        public int MiniUnitId { get; set; }
        public int UnitSourceId { get; set; }

        public UnitSourceActiveUpdate()
        {
        }

        public UnitSourceActiveUpdate(string _Field, int _MiniUnitId, int _UnitSourceId)
        {
            Field = _Field;
            MiniUnitId = _MiniUnitId;
            UnitSourceId = _UnitSourceId;
        }
    }
}