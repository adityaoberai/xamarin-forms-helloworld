# Hello World With Xamarin.Forms

<img src="Assets/Images/Title.PNG?raw=true" alt="Title" width="auto" height="auto">

---

## Description

This repository contains the **HelloWorld** app created during the [Hello World With Xamarin.Forms](https://www.youtube.com/watch?v=KGPakBXrv-Q) session

The session is based on the [Hello World in 10 minutes](https://github.com/adityaoberai/xamarin-forms-helloworld#resources) Xamarin Tutorial

[(Download the PPT here)](Assets/Slides/Hello_World_With_Xamarin_Forms.pptx)
 
<br>
<br>

<img src="Assets/Images/HelloWorld_App.png?raw=true" alt="App Screenshot" width="250" height="auto">

<br>
<br>

---

## Prerequisites For This Activity

* No knowledge prerequisites for this tutorial

* Knowledge of **C#** is necessary for developing more complex apps later

---

## Developing The App

### Prerequisites

1. Download the [Visual Studio IDE](https://visualstudio.microsoft.com/)

2. Install the **Mobile development with .NET** workload

### Step 1: Create a new Xamarin.Forms app

1. Open **Visual Studio 2019**

2. Select **Create a new project**

3. Enter **Xamarin.Forms** in the search bar

4. Select the **Mobile App (Xamarin.Forms)** template and click **Next**

5. Enter **HelloWorld** as the project name, set the project repository, and click **Create**

6. Select the **Blank** template. Ensure **Android**, **iOS**, and **Windows (UWP)** are all selected, and click **OK**

*Note: Specific versions of the* **Android SDK** *are required to build projects. If your machine is missing the required SDK, you'll see the following prompt while the new project is loading. Click* **Accept** *to have the automatic installation begin.*

### Step 2: Create the shared [UI](HelloWorld/HelloWorld/MainPage.xaml)

1. Go to **MainPage.xaml** under the project **HelloWorld**

2. Remove all the template code in between the **StackLayout** opening and closing tags so that the **MainPage.xaml** now looks like:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="HelloWorld.MainPage">

    <StackLayout>
        
    </StackLayout>

</ContentPage>
```

3. Add a **Label** with the text *Hello World!* and a **Button** with the text *Click Me* inside the **StackLayout** opening and closing tags:

```xml
...
<StackLayout>
        
    <Label 
        Text="Hello World!" 
        HorizontalOptions="CenterAndExpand" 
        VerticalOptions="CenterAndExpand" 
        FontSize="Title"/>

    <Button 
        x:Name="click"
        Text="Click Me" 
        Clicked="click_Clicked"/>

</StackLayout>
...
```
*Note: You can change some of the attributes in their to tweak the look and feel of the app as per your preference*

### Step 3: Create the shared [backend](HelloWorld/HelloWorld/MainPage.xaml.cs)

1. Go to **MainPage.xaml.cs** under the project **HelloWorld**

2. Create an Event Handler **click_Clicked** under the constructor in the partial class **MainPage**

```csharp
...
private void click_Clicked(object sender, EventArgs e)
{
    count++;
    ((Button)sender).Text = $"You have clicked {count} times!";
}
...
```
### Step 4: Run The App

1. From the menu, select **Debug > Start Debugging**

2. **Congratulations, you've built and run your first Xamarin.Forms app!!!**

---

## Cloning And Running The App

Please follow the following steps to run the project in **Visual Studio IDE**

1. Clone the repository to a location of your preference

2. Open the project in Visual Studio 2019 by clicking on **HelloWorld.sln**

3. Build the project
 
4. Run and enjoy :)

---

## Resources

* [Xamarin Tutorial - Hello World in 10 minutes](https://dotnet.microsoft.com/learn/xamarin/hello-world-tutorial/intro) - *first app activity*

* [Build mobile apps with Xamarin.Forms (Microsoft Learn)](https://docs.microsoft.com/en-us/learn/paths/build-mobile-apps-with-xamarin-forms/) - *recommended*

* [Learn Xamarin (.NET)](https://dotnet.microsoft.com/learn/xamarin)

* [Xamarin.Forms Quickstarts](https://docs.microsoft.com/en-us/xamarin/get-started/quickstarts/)

* [Take your first steps with C# (Microsoft Learn)](https://docs.microsoft.com/en-us/learn/paths/csharp-first-steps/)

*Note: If you'd like to share more resources, do create a pull request and add them above this message :)*