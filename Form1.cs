using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Testing_Display_service_type_and_services
{
    public partial class Form1 : Form
    {
        public readonly string mysqlcon;
        private readonly CallOutServiceType_Service serviceTypeService;

        public Form1()
        {
            InitializeComponent();
            mysqlcon = "server=localhost;user=root;database=salondatabase;password=";
            serviceTypeService = new CallOutServiceType_Service();
            GetServiceTypeData();
            GetServiceData();
        }

        public void GetServiceTypeData()
        {
            serviceTypeService.GetServiceTypeData(ServiceTypeFL, mysqlcon, UpdateServiceFL);
        }

        public void GetServiceData()
        {
            serviceTypeService.GetServiceData(ServiceFL, mysqlcon);
        }

        private void UpdateServiceFL(string serviceTypeID)
        {
            serviceTypeService.UpdateServiceFL(ServiceFL, serviceTypeID, mysqlcon);
        }
    }
}
