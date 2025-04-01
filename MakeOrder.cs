using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeeShop_Management
{
    public partial class Make_Order : Form
    {
        // List to store items in cart
        private List<CartItem> cartItems = new List<CartItem>();

        // Coffee product class
        public class CoffeeProduct
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string ImagePath { get; set; }
            public string Description { get; set; }
        }

        // Cart item class
        public class CartItem
        {
            public CoffeeProduct Product { get; set; }
            public int Quantity { get; set; }
            public List<string> Customizations { get; set; }

            public decimal TotalPrice
            {
                get { return Product.Price * Quantity; }
            }
        }

        // Sample coffee data
        private List<CoffeeProduct> coffeeProducts = new List<CoffeeProduct>
        {
            new CoffeeProduct
            {
                Name = "Espresso",
                Price = 2.50m,
                ImagePath = "/placeholder.svg?height=100&width=100",
                Description = "Strong black coffee made by forcing steam through ground coffee beans"
            },
            new CoffeeProduct
            {
                Name = "Cappuccino",
                Price = 3.50m,
                ImagePath = "/placeholder.svg?height=100&width=100",
                Description = "Espresso with steamed milk foam"
            },
            new CoffeeProduct
            {
                Name = "Latte",
                Price = 3.75m,
                ImagePath = "/placeholder.svg?height=100&width=100",
                Description = "Espresso with steamed milk"
            },
            new CoffeeProduct
            {
                Name = "Americano",
                Price = 2.75m,
                ImagePath = "/placeholder.svg?height=100&width=100",
                Description = "Espresso with hot water"
            },
            new CoffeeProduct
            {
                Name = "Mocha",
                Price = 4.00m,
                ImagePath = "/placeholder.svg?height=100&width=100",
                Description = "Espresso with chocolate and steamed milk"
            },
            new CoffeeProduct
            {
                Name = "Macchiato",
                Price = 3.25m,
                ImagePath = "/placeholder.svg?height=100&width=100",
                Description = "Espresso with a small amount of milk"
            },
            new CoffeeProduct
            {
                Name = "Cold Brew",
                Price = 3.50m,
                ImagePath = "/placeholder.svg?height=100&width=100",
                Description = "Coffee brewed with cold water over a long period"
            },
            new CoffeeProduct
            {
                Name = "Flat White",
                Price = 3.75m,
                ImagePath = "/placeholder.svg?height=100&width=100",
                Description = "Espresso with steamed milk and microfoam"
            }
        };

        public Make_Order()
        {
            InitializeComponent();
        }

        private void Make_Order_Load(object sender, EventArgs e)
        {
            // Create coffee cards
            CreateCoffeeCards();

            // Initialize cart
            UpdateCartDisplay();
        }

        private void CreateCoffeeCards()
        {
            // Clear existing controls
            flpCoffeeItems.Controls.Clear();

            // Create a card for each coffee product
            foreach (var coffee in coffeeProducts)
            {
                // Create panel for coffee card
                Panel coffeeCard = new Panel
                {
                    Width = 180,
                    Height = 220,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };

                // Create image placeholder
                PictureBox coffeeImage = new PictureBox
                {
                    Width = 100,
                    Height = 100,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Location = new Point(40, 10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                // For a real application, you would load actual images
                // coffeeImage.Image = Image.FromFile(coffee.ImagePath);
                // For this example, we'll use a placeholder
                coffeeImage.BackColor = Color.LightGray;

                // Create name label
                Label coffeeName = new Label
                {
                    Text = coffee.Name,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Width = 160,
                    Height = 20,
                    Location = new Point(10, 115)
                };

                // Create price label
                Label coffeePrice = new Label
                {
                    Text = $"${coffee.Price:F2}",
                    Font = new Font("Arial", 10),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Width = 160,
                    Height = 20,
                    Location = new Point(10, 140)
                };

                // Create add to cart button
                Button addToCartBtn = new Button
                {
                    Text = "Add to Cart",
                    Width = 160,
                    Height = 30,
                    Location = new Point(10, 170),
                    BackColor = Color.FromArgb(92, 184, 92),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };

                // Store the coffee product in the button's Tag property
                addToCartBtn.Tag = coffee;

                // Add click event handler
                addToCartBtn.Click += AddToCartBtn_Click;

                // Add controls to the card
                coffeeCard.Controls.Add(coffeeImage);
                coffeeCard.Controls.Add(coffeeName);
                coffeeCard.Controls.Add(coffeePrice);
                coffeeCard.Controls.Add(addToCartBtn);

                // Add card to the flow layout panel
                flpCoffeeItems.Controls.Add(coffeeCard);
            }
        }

        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            // Get the coffee product from the button's Tag property
            Button btn = (Button)sender;
            CoffeeProduct coffee = (CoffeeProduct)btn.Tag;

            // Show the customize order form
            using (CustomizeOrder customizeForm = new CustomizeOrder(coffee))
            {
                if (customizeForm.ShowDialog() == DialogResult.OK)
                {
                    // Add the customized item to cart
                    CartItem item = new CartItem
                    {
                        Product = coffee,
                        Quantity = customizeForm.Quantity,
                        Customizations = customizeForm.SelectedCustomizations
                    };

                    cartItems.Add(item);

                    // Update the cart display
                    UpdateCartDisplay();
                }
            }
        }

        private void UpdateCartDisplay()
        {
            // Clear existing items
            lstCart.Items.Clear();

            // Add each cart item to the list view
            decimal total = 0;

            foreach (var item in cartItems)
            {
                // Create list view item with product name and quantity
                ListViewItem listItem = new ListViewItem(item.Product.Name);
                listItem.SubItems.Add(item.Quantity.ToString());

                // Add customizations as a comma-separated string
                string customizations = string.Join(", ", item.Customizations);
                listItem.SubItems.Add(customizations);

                // Add price
                listItem.SubItems.Add($"${item.TotalPrice:F2}");

                // Add to list view
                lstCart.Items.Add(listItem);

                // Add to total
                total += item.TotalPrice;
            }

            // Update total label
            lblTotal.Text = $"Total: ${total:F2}";
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            // Clear cart
            cartItems.Clear();
            UpdateCartDisplay();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (cartItems.Count == 0)
            {
                MessageBox.Show("Your cart is empty.", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Calculate total
            decimal total = 0;
            foreach (var item in cartItems)
            {
                total += item.TotalPrice;
            }

            // Show checkout message
            MessageBox.Show($"Total: ${total:F2}\nThank you for your order!", "Checkout Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear cart after checkout
            cartItems.Clear();
            UpdateCartDisplay();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (lstCart.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to remove.", "Remove Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get the selected index
            int index = lstCart.SelectedIndices[0];

            // Remove the item from the cart
            cartItems.RemoveAt(index);

            // Update the cart display
            UpdateCartDisplay();
        }
    }
}