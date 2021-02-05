﻿
"use strict";
window.onload = Init();
var user = new User();

function Init() {
    $(".minimizeChat").click(ToggleChat);
    var span = document.getElementsByClassName("closeChat")[0];
    span.onclick = function () {
        CloseChat();
    };

    RegisterModal();
    RegisterInput();
    //addMessage('s', 'first', 'username', 'sometimes');

}


function ToggleChat(){
    $("#user-chat-container").toggle();
}

function CloseChat() {
    $("#Modal").toggle();
}

function RegisterModal() {
    var modal = document.getElementById("Modal");
    var btn = document.getElementById("modalYes");
    btn.addEventListener("click", function () {
        $("#Modal").toggle();
        ToggleChat();
         //OnDisconnect();
    }, false);

    btn = document.getElementById("modalNo");
    btn.addEventListener("click", function () { modal.style.display = "none"; }, false);
    var span = document.getElementsByClassName("closeModal")[0];
    span.onclick = function () {
        modal.style.display = "none";
    };
    window.onclick = function (event) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
    };
}

function RegisterInput() {
    $("#chat-submit").click(function (e) {
        e.preventDefault();
        var msg = $("#chat-input").val();
        if (msg.trim() == '') {
            return false;
        }
        addMessage(msg, 'first','username','sometimes');

        setTimeout(function () {
            addMessage(msg, 'second', 'connectedSpecName','tooLate');
        }, 1000);

    });
}

function addMessage(msg, type, name, time) {
    var str = "";
    str += "<div  class=\"chat " + type + "\">";
    if (type === "first") {
        str += "              <i class=\"fas fa-users\"><\/i>";
    }
    else {
        str += "            <img src=\"https://www.w3schools.com/howto/img_avatar.png\" alt=\"Avatar\" class=\"right\">";
    }
    str += "              <span class=\"name\">" + name + "<\/span>";
    str += "              <p class=\"chat\">" + msg + "<\/p>";
    str += "              <span class=\"time time-right\">" + time + "<\/span>";
    str += "          <\/div>";

    $(".chat-messages").append(str);
    if (type == 'first') {
        $("#chat-input").val('');
    }
    $(".chat-messages").stop().animate({ scrollTop: $(".chat-messages")[0].scrollHeight }, 1000);

}