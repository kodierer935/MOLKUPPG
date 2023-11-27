using Microsoft.VisualStudio.TestTools.UnitTesting;
using MJU23v_D15_inl_todolist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MJU23v_D15_inl_todolist.Todo;

namespace MJU23v_D15_inl_todolist.Tests;

[TestClass()]

public class TodoItemTests
{
    [TestMethod()]

    public void TodoItemTest1()
    {
        Todo.TodoItem myTask1 = new Todo.TodoItem (2, "Ny ubbgift prio 2");
        
        Assert.AreEqual(2, myTask1.priority);
        Assert.AreEqual("Ny ubbgift prio 2", myTask1.task);
        Assert.IsNotNull(myTask1, "TodoItem should not be null.");

    }

    [TestMethod()]
    public void TodoItemTest2()
    {
        Todo.TodoItem myTask = new Todo.TodoItem("2|3|köpa soffa|IKEA");
        Assert.AreEqual(2, myTask.status);
        Assert.AreEqual(3, myTask.priority);
        Assert.AreEqual("köpa soffa", myTask.task);
        Assert.AreEqual("IKEA", myTask.taskDescription);
        
        Assert.IsNotNull(myTask, "should not be null.");


    }

    [TestMethod()]
    public void ToStringTest1()
    {
        TodoItem myTask = new TodoItem("2|3|köpa soffa|IKEA");
        string expected = "|väntande    |3     |köpa soffa          |";
        string actual = myTask.ToString(false);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void ToStringTest2()
    {
        TodoItem myTask = new TodoItem("2|3|köpa soffa|IKEA");
        string expected = "|väntande    |3     |köpa soffa          |IKEA                                    |";
        string actual = myTask.ToString(true);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void SetWaitingTest()
    {
        Todo.TodoItem myTask1 = new Todo.TodoItem(2, "Ny ubbgift prio 2");
        myTask1.status = 2;
        bool ret = myTask1.SetActive();
        Assert.IsTrue(ret);
        
    }

    [TestMethod()]
    public void SetReadyTest()
    {
        Todo.TodoItem myTask1 = new Todo.TodoItem(2, "Ny ubbgift prio 2");
        myTask1.status = 3;
        myTask1.SetReady();
        bool ret = myTask1.SetActive();
        Assert.IsFalse(myTask1.SetReady());

    }

    [TestMethod()]
    public void SetWaigTest()
    {
        Todo.TodoItem myTask1 = new Todo.TodoItem(2, "Ny ubbgift prio 2");
        string expected = "aktiv";
        Assert.AreEqual(expected,myTask1.StatusString());

    }
}