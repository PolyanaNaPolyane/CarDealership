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

        private void approveButton_Click(object sender, EventArgs e)
        {
            ToggleOrderApproving(true, "Оберіть заявку для підтвердження");
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            ToggleOrderApproving(false, "Оберіть заявку для відхилення");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!ordersGridView.IsSelectedRow())
            {
                MessageUtil.ShowError("Оберіть заявку для видалення");
                return;
            }

            _orderRepository.Delete(SelectedOrder);
            ordersGridView.DataSource = _orderRepository.Entities.ToTableData();
        }

        private void ToggleOrderApproving(bool isApproved, string message)
        {
            if (!ordersGridView.IsSelectedRow())
            {
                MessageUtil.ShowError(message);
                return;
            }

            var orderToToggleApproving = SelectedOrder;

            if (orderToToggleApproving.IsApproved == isApproved)
            {
                MessageUtil.ShowError($"Заявку вже {(isApproved ? "підтверджено" : "відхилено")}");
                return;
            }

            orderToToggleApproving.IsApproved = isApproved;
            _orderRepository.Update(orderToToggleApproving);
            ordersGridView.DataSource = _orderRepository.Entities.ToTableData();
        }
    }
}
