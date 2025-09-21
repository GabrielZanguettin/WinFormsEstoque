using System.Net.Http.Json;
using EstoqueWinForms.Api;
using EstoqueWinForms.Contracts;

namespace EstoqueWinForms
{
    public partial class Form1 : Form
    {
        private readonly ApiClient _api;

        public Form1()
        {
            InitializeComponent();
            _api = new ApiClient("https://localhost:7284");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = textBox1.Text?.Trim();
                var descricao = richTextBox1.Text?.Trim();

                var dto = new CreateProductDto(nome, descricao);

                var resp = await _api.CreateProductAsync(dto);
                var result = await resp.Content.ReadFromJsonAsync<ApiResponse<ProductDto>>();

                if (result?.Data is null)
                {
                    MessageBox.Show(result?.Message, "Resposta da API",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show(
                    $"{result.Message}\n" +
                    $"Id: {result.Data.Id}\n" +
                    $"Name: {result.Data.Name}\n" +
                    $"Description: {result.Data.Description}\n" +
                    $"Stock: {result.Data.Stock}",
                    "Resposta da API",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                textBox1.Clear();
                richTextBox1.Clear();
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar produto: " + ex.Message);
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var resp = await _api.GetProductByIdAsync(int.Parse(textBox4.Text));
                var result = await resp.Content.ReadFromJsonAsync<ApiResponse<ProductDto>>();

                if (result?.Data is null)
                {
                    var msg = result?.Message;
                    MessageBox.Show(msg, "Resposta da API", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show(
                    $"{result?.Message}\n" +
                    $"Id: {result?.Data?.Id}\n" +
                    $"Name: {result?.Data?.Name}\n" +
                    $"Description: {result?.Data?.Description}\n" +
                    $"Stock: {result?.Data?.Stock}",
                    "Resposta da API",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar: " + ex.Message);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {}

        private void Form1_Load(object sender, EventArgs e) {}

        private void textBox4_TextChanged(object sender, EventArgs e) {}

        private void textBox1_TextChanged(object sender, EventArgs e) {}

        private void textBox2_TextChanged(object sender, EventArgs e) {}

        private void textBox3_TextChanged(object sender, EventArgs e) {}

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(textBox2.Text);
                var qty = int.Parse(textBox3.Text);

                var resp = await _api.DecrementStockAsync(id, new UpdateProductDto(qty));
                var result = await resp.Content.ReadFromJsonAsync<ApiResponse<ProductDto>>();

                if (result?.Data is null)
                {
                    MessageBox.Show(result?.Message, "Resposta da API",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show(
                    $"{result.Message}\n" +
                    $"Id: {result.Data.Id}\n" +
                    $"Name: {result.Data.Name}\n" +
                    $"Description: {result.Data.Description}\n" +
                    $"Stock: {result.Data.Stock}",
                    "Resposta da API",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover: " + ex.Message);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) {}

        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var filters = new ProductFiltersDto
                {
                    Page = string.IsNullOrWhiteSpace(textBox7.Text) ? null : int.Parse(textBox7.Text),
                    PageSize = string.IsNullOrWhiteSpace(textBox8.Text) ? null : int.Parse(textBox8.Text)
                };

                var resp = await _api.ListProductsAsync(filters);
                var result = await resp.Content.ReadFromJsonAsync<ApiResponse<List<ProductDto>>>();

                if (result?.Data is null)
                {
                    MessageBox.Show(result?.Message,
                                    "Resposta da API", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var sb = new System.Text.StringBuilder();
                sb.AppendLine(result.Message);

                foreach (var p in result.Data)
                {
                    sb.AppendLine($"Id: {p.Id}");
                    sb.AppendLine($"Name: {p.Name}");
                    sb.AppendLine($"Description: {p.Description}");
                    sb.AppendLine($"Stock: {p.Stock}");
                    sb.AppendLine();
                }

                MessageBox.Show(sb.ToString(), "Resposta da API",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar: " + ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {}

        private void Form1_Load_1(object sender, EventArgs e) {}

        private void textBox5_TextChanged(object sender, EventArgs e) {}

        private void textBox6_TextChanged(object sender, EventArgs e) {}

        private async void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(textBox5.Text);
                var qty = int.Parse(textBox6.Text);

                var resp = await _api.IncrementStockAsync(id, new UpdateProductDto(qty));
                var result = await resp.Content.ReadFromJsonAsync<ApiResponse<ProductDto>>();

                if (result?.Data is null)
                {
                    MessageBox.Show(result?.Message, "Resposta da API",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show(
                    $"{result.Message}\n" +
                    $"Id: {result.Data.Id}\n" +
                    $"Name: {result.Data.Name}\n" +
                    $"Description: {result.Data.Description}\n" +
                    $"Stock: {result.Data.Stock}",
                    "Resposta da API",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar: " + ex.Message);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e) {}

        private void textBox8_TextChanged(object sender, EventArgs e) {}
    }
}
