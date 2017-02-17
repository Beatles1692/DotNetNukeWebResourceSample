<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="MyModule.View" %>
<div dir="ltr">
    <h1><span id="applicationName"></span></h1>
    <h1>
    Hello <span id="nameSpan" class="name">World</span>!
</h1>
<div>
    <label for="name">What is your name?</label>
    <input type="text" name="name" />
    <label id="nameError" style="color: red">Please enter your name</label>
    <button type="button" onclick="buttonclicked()">Click me!</button>    
</div>
    
</div>
