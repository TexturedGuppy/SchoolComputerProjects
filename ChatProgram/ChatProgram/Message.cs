using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatProgram
{
    enum MessageType
    {
        Chat, Login, Whisper
    }

    class ChatMessage
    {
        MessageType type = MessageType.Chat;
        string chatContent;
        ChatMessage(string content)
        {
            chatContent = content;
        }
    }

    class LoginMessage
    {
        MessageType type = MessageType.Login;
        string username;
        //string password;

        LoginMessage(string user)
        {
            username = user;
        }
    }

    class WhisperMessage //Private Message
    {

        MessageType type = MessageType.Whisper;
        string username;
        string chatContent;

    }

}
