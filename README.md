# cs-test

This project demonstrates a simple Selenium WebDriver test that interacts with the Trendyol website. The test performs the following actions:

1.  Launches the Chrome browser.
2.  Navigates to [Trendyol](https://www.trendyol.com/).
3.  Closes a modal window that appears on the page.
4.  Closes the browser.

## Prerequisites

Ensure the following tools are installed on your system:

-   .NET SDK (version 6 or higher)
-   ChromeDriver (version matching your Chrome browser)
-   Selenium WebDriver for C#

## How to Build and Run the Test

### 1. Clone the Repository

Clone this repository to your local machine:

```bash
git clone https://github.com/yburakyo/cs-test.git
cd cs-test

```

### 2. Build the Project

Run the following command to build the project:

```bash
dotnet build

```

### 3. Run the Test

To execute the test, run:

```bash
dotnet test

```

This will execute the `Test1` method, launching the browser, performing the actions, and then closing the browser.

## Notes

-   Ensure that your Chrome browser version is compatible with the installed `ChromeDriver`.
-   If you encounter any issues related to ChromeDriver, you may need to update it or specify its location in the project.