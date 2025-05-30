namespace CarDealership.Extensions
{
    public static class DataGridViewExtensions
    {
        public static bool IsSelectedRow(this DataGridView dataGridView)
        {
            return dataGridView.SelectedRows.Count > 0;
        }
    }
}
