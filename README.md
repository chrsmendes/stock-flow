# Welcome to StockFlow!

This is intended to make your life easier as a storehouse! You can manage all your products in a single app.

## Team Members
- Christopher Lei Bossle Mendes
- Stephen Richard Brown

## How to Run Locally (Fresh Start)

This project uses SQLite for local development. Because the app has two database contexts, you need to specify them when updating. 

Follow this step-by-step guide to delete any old data and run the app from scratch:

**1. Delete the old database (if it exists):**
```bash
rm stock-flow.db

```

*(On Windows, you can just right-click and delete the `stock-flow.db` file).*

**2. Create the Authentication tables:**

```bash
dotnet ef database update --context ApplicationDbContext

```

**3. Create the Inventory tables:**

```bash
dotnet ef database update --context InventoryDbContext

```

**4. Run the application:**

```bash
dotnet watch

```