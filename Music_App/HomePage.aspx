<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="Music_App.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.7.2/font/bootstrap-icons.css" />
    <link rel="stylesheet" href="./Static/Style.css" />

</head>
<body>
        <form runat="server" id="form1">
    <header>
        <div class="menu_side">
        <h1>Playlist</h1>
        <div class="playlist">
            <h4 class="active"><span></span><i class="bi bi-music-note-beamed"></i> Playlist</h4>
            <h4 ><span></span><i class="bi bi-music-note-beamed"></i> Last Listening</h4>
            <h4 ><span></span><i class="bi bi-music-note-beamed"></i> Recommended</h4>
        </div>
        <div class="menu_song">
            <li class="songItem">
                <span>06</span>
                <img src="Static/Images/1.jpg" alt="Alan" />
                <h5>
                    On My Way
                    <div class="subtitle">Alan Walker</div>
                </h5>
                  <a class="bi playListPlay bi-play-circle-fill" runat="server" onserverclick="Play_Button" style="text-decoration:none" id="play"></a>
                <%--<asp:Button Text="Pause" runat="server" OnClick="Play_Button" />--%>
                <asp:Button Text="Pause" runat="server" OnClick="Pause_Button" />
                <asp:Button Text="Stop" runat="server" OnClick="Stop_Button" />
            </li>
        </div>
    </div>

        <div class="song_side">
        <nav>
            <ul>
                <li>Discover <span></span></li>
                <li>MY LIBRARY</li>
                <li>RADIO</li>
            </ul>
            <div class="search">
                <i class="bi bi-search"></i>
                <input type="text" placeholder="Search Music...">
            </div>
            <div class="user">
                <img src="Static/Images/KDS CODER.png" alt="User" title="KDS CODER (Jahid Khan)">
            </div>
        </nav>
        <div class="content">
            <h1>Alen Walker-Fade</h1>
            <p>
                You were the shadow to my light Did you feel us Another start You fade 
                <br>
                Away afraid our aim is out of sight Wanna see us Alive
            </p>
            <div class="buttons">
                <button>PLAY</button>
                <button>FOLLOW</button>
            </div>
        </div>
        <div class="popular_song">
            <div class="h4">
                <h4>Popular Song</h4>
                <div class="btn_s">
                    <i id="left_scroll" class="bi bi-arrow-left-short"></i>
                    <i id="right_scroll" class="bi bi-arrow-right-short"></i>
                </div>
            </div>
            <div class="pop_song">
                <li class="songItem">
                    <div class="img_play">
                        <img src="Static/Images/1.jpg" alt="alan">
                        <i class="bi playListPlay bi-play-circle-fill" id="15"></i>
                    </div>
                    <h5>On My Way
                        <br>
                        <div class="subtitle">Alan Walker</div>
                    </h5>
                </li>
            </div>
        </div>
        <div class="popular_artists">
            <div class="h4">
                <h4>Popular Artists</h4>
                <div class="btn_s">
                    <i id="left_scrolls" class="bi bi-arrow-left-short"></i>
                    <i id="right_scrolls" class="bi bi-arrow-right-short"></i>
                </div>
            </div>
            <div class="item">
                <li>
                    <img src="Static/Images/arjit.jpg" alt="Arjit Singh" title="Arjit Singh" />
                </li>
                <!-- change all img  -->
            </div>
        </div>
    </div>

        <div class="master_play">
        <div class="wave">
            <div class="wave1"></div>
            <div class="wave1"></div>
            <div class="wave1"></div>
        </div>
        <img src="Static/Images/26th.jpg" alt="Alan" id="poster_master_play" />
        <h5 id="title">Vande Mataram<br>
            <div class="subtitle">Bankim Chandra</div>
        </h5>
        <div class="icon">
            <i class="bi bi-skip-start-fill" id="back"></i>
            <i class="bi bi-play-fill" id="masterPlay" runat="server"></i>
            <i class="bi bi-skip-end-fill" id="next"></i>
        </div>
        <span id="currentStart">0:00</span>
        <div class="bar">
            <input type="range" id="seek" min="0" value="0" max="100" />
            <div class="bar2" id="bar2"></div>
            <div class="dot"></div>
        </div>
        <span id="currentEnd">0:00</span>

        <div class="vol">
            <i class="bi bi-volume-down-fill" id="vol_icon"></i>
            <input type="range" id="vol" min="0" value="30" max="100" />
            <div class="vol_bar"></div>
            <div class="dot" id="vol_dot"></div>
        </div>
    </div>

    </header>
    </form>
</body>
</html>
