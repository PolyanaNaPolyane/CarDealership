using CarDealership.Entities;
using CarDealership.Extensions;
using CarDealership.Interfaces;
using CarDealership.Utils;

namespace CarDealership.Forms
{
    public partial class Orders : Form
    {
        private readonly IOrderRepository _orderRepository = RepositoryFactoryUtil.OrderRepository;

        public Orders()
        {
            InitializeComponent();
            InitializeTables();
        }

        public Order SelectedOrder => _orderRepository.Entities.ToList()[ordersGridView.SelectedRows[0].Index];

        private void InitializeTables()
        {
            ordersGridView.DataSource = _orderRepository.Entities.ToTableData();
        }

        private void toggleOrderApproving_Click(object sender, EventArgs e)
        {
            var orderToToggleApproving = SelectedOrder;
            orderToToggleApproving.IsApproved = !orderToToggleApproving.IsApproved;
            _orderRepository.Update(orderToToggleApproving);
            ordersGridView.DataSource = _orderRepository.Entities.ToTableData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            _orderRepository.Delete(SelectedOrder);
            ordersGridView.DataSource = _orderRepository.Entities.ToTableData();
        }
    }
}
