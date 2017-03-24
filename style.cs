html, body, #CenterPan {
  height: 100%;
}
body {
	padding: 0;
	margin: 0;
}

#main {
	margin: auto;
	position: relative;
	text-align: center;
	height: 94%;
	width: 98%;
}
#main div {
	margin: 2px;
	float: left;
	border: solid 2px #C4C4C4;
	height: 100%;
	text-align: left;
}

#LeftPan {
	width: 30%;
	padding: 4px;
}

#CenterPan {
	display: flex;
  	flex-direction: column;
	width: 35%;
	padding: 4px;
}
#CenterPan #inck {
	position: relative;
	float: left;
	width: 49%;
	height: 50px;
	margin: 2px 0;
}
#CenterPan #deck {
	position: relative;
	float: right;
	width: 49%;
	height: 50px;
	margin: 2px 0;
}
#CenterPan #inK {
	position: relative;
	float: left;
	width: 100%;
	margin: 2px 0;
	box-sizing: border-box;
	resize: none;
}
#CenterPan #inT {
	text-anchor: start;
	position: relative;
	float: left;
	width: 100%;
	height: 80%;
	size: 100;
	margin: 2px 0;box-sizing: border-box;
	resize: none;
}
#CenterPan #fileLoa {
	position: relative;
	float: left;
	width: 49%;
	margin: 2px 0;
}
#CenterPan #fileDo {
	position: relative;
	float: right;
	width: 49%;
	margin: 2px 0;
}
#RightPan {
	padding: 4px;
	width: 30%;
}
