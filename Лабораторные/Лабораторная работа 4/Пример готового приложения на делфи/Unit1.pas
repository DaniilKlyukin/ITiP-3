unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ExtCtrls, StdCtrls, Spin;

type
  TForm1 = class(TForm)
    Button1: TButton;
    Image1: TImage;
    Button2: TButton;
    Button3: TButton;
    SpinButton1: TSpinButton;
    Button4: TButton;
    Button5: TButton;
    Edit1: TEdit;
    Edit2: TEdit;
    Label2: TLabel;
    Label3: TLabel;
    RadioGroup1: TRadioGroup;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure SpinButton1DownClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure SpinButton1UpClick(Sender: TObject);
    procedure Button4Click(Sender: TObject);
    procedure Button5Click(Sender: TObject);
    procedure Button1MouseDown(Sender: TObject; Button: TMouseButton;
      Shift: TShiftState; X, Y: Integer);
    procedure Button2MouseDown(Sender: TObject; Button: TMouseButton;
      Shift: TShiftState; X, Y: Integer);
    procedure Button5MouseDown(Sender: TObject; Button: TMouseButton;
      Shift: TShiftState; X, Y: Integer);
    procedure Image1MouseDown(Sender: TObject; Button: TMouseButton;
      Shift: TShiftState; X, Y: Integer);
    procedure Image1MouseUp(Sender: TObject; Button: TMouseButton;
      Shift: TShiftState; X, Y: Integer);
    procedure Image1MouseMove(Sender: TObject; Shift: TShiftState; X,
      Y: Integer);
    procedure FormKeyDown(Sender: TObject; var Key: Word;
      Shift: TShiftState);
    procedure Edit1KeyPress(Sender: TObject; var Key: Char);
    procedure RadioGroup1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

const eps=0.000001;
var
  Form1: TForm1;
    bitmap:tbitmap;
    MousePressed: boolean=false;
  num, num1, step:extended;   a,b,ind,expon:integer;
  xrex, rey, xmin,ymin,xmax,ymax:extended; xg, yg:integer;
  xmin1,ymin1,xmax1,ymax1:extended; x1,y1,x2,y2:integer;
   ind2, ind3:integer; pmin,pmax,qmin,qmax:extended;
implementation

{$R *.dfm}
  //Жюлиа
procedure TForm1.Button1Click(Sender: TObject);
var i,j,k,nx,ny,n:integer;
    p,q,x,y,dx,dy,x0,y0,xk1,yk1:extended;
    c:byte;
begin

  image1.Refresh;  ind:=1;
 // xmin:=-1.5; xmax:=1.5; ymin:=-1.5; ymax:=1.5;
 // a:=image1.Width; b:=image1.Height;
  dx:=(xmax-xmin)/a; dy:=(ymax-ymin)/b;
  p:=strtofloat(edit2.Text); q:=strtofloat(edit1.Text);
  for i:=1 to image1.Width do
    for j:=1 to image1.Height do
      begin
        x:=xmin+i*dx; y:=ymin+j*dy;  n:=0;
        while (sqr(x)+sqr(y))<2 do
            begin
              xk1:=sqr(x)-sqr(y)+p;
              yk1:=2*x*y+q;
              inc(n);
              if n=100 then break;
              x:=xk1; y:=yk1;
            end;
          c:=round(255*(1-n/100));
          case radiogroup1.ItemIndex of
            0: image1.Canvas.Pixels[i,j]:=rgb(c,c,c);
          1: image1.Canvas.Pixels[i,j]:=rgb(3*round(sin(n)*c),2*round(sin(n)*c),round(sin(n)*c));
          2: image1.Canvas.Pixels[i,j]:=rgb(3*c,2*c,c);
          else exit;
          end;

         // image1.Canvas.Pixels[i,j]:=rgb(3*c,2*c,1*c);
      end;

end;
  //Мандельброт
procedure TForm1.Button2Click(Sender: TObject);
var i,j,k,n:integer;  c:byte;
    x,y,x1,y1,p,q, dp, dq:extended;
begin
   image1.Refresh;   ind:=2;
 //  a:=image1.Width; b:=image1.Height;
 //  pmin:=-1.5; qmin:=-1.5; pmax:=1.5; qmax:=1.5;
   dp:=(pmax-pmin)/a; dq:=(qmax-qmin)/b;
   for i:=1 to a do
    for j:=1 to b do
      begin
         p:=pmin+i*dp; q:=qmin+j*dq; n:=0;  x:=0; y:=0;
         while (sqr(x)+sqr(y))<2 do
            begin
              x1:=sqr(x)-sqr(y)+p;
              y1:=2*x*y+q;
              inc(n);
              if n=100 then break;
              x:=x1; y:=y1;
            end;
          c:=round(255*(1-n/100));
          case radiogroup1.ItemIndex of
            0: image1.Canvas.Pixels[i,j]:=rgb(c,c,c);
           1: image1.Canvas.Pixels[i,j]:=rgb(3*round(sin(n)*c),2*round(sin(n)*c),round(sin(n)*c));
            2: image1.Canvas.Pixels[i,j]:=rgb(3*c,2*c,c);
          else exit;
         end;
      end;
end;

procedure TForm1.SpinButton1DownClick(Sender: TObject);
begin
  num:=num-step;
  if num=0 then begin  num:=num+step; exit; end else
    begin
      case ind of
        1: begin image1.Canvas.Brush.Color:=clwhite;
           image1.Canvas.Rectangle(0,0,image1.Width,image1.Height); a:=round(a*num);
            b:=round(b*num);   button1.Click; a:=image1.Width; b:=image1.Height;  end;
      2: begin image1.Canvas.Refresh; a:=round(a*num);
           image1.Canvas.Brush.Color:=clwhite;
           image1.Canvas.Rectangle(0,0,image1.Width,image1.Height);
          b:=round(b*num);     button2.Click; a:=image1.Width; b:=image1.Height;  end;
      3: begin  image1.Canvas.Brush.Color:=clwhite;
          image1.Canvas.rectangle(0,0,image1.Width,image1.Height);
          a:=round(a*num);
          b:=round(b*num);     button5.Click; a:=image1.Width; b:=image1.Height;  end    
      else exit;
    end;
    end;

end;

procedure TForm1.FormCreate(Sender: TObject);
//var myHWND:  HWND;
begin
 // image1.Canvas.Create;
 //myHWND:=image1.Picture.Bitmap.Handle;
// image1.Canvas.Handle:=GetDC(myHWND);
 radiogroup1.ItemIndex:=0;
 Image1.Canvas.Pen.Color:=clred;
 image1.Canvas.Brush.Style:=bsclear;
 bitmap:=tbitmap.Create;
 bitmap.Width:=image1.Width;
 bitmap.Height:=image1.Height;
 form1.KeyPreview:=true;
  num:=1; step:=0.25; ind:=0;   a:=image1.Width; b:=image1.Height; num1:=1;
  expon:=0;  ind2:=0;  ind3:=0;
end;

procedure TForm1.SpinButton1UpClick(Sender: TObject);
//var a,b:integer;
begin      
      a:=image1.Width; b:=image1.Height;
      num:=num+step;  //edit1.Text:=floattostr(num);
    case ind of
      1: begin image1.Canvas.Refresh;

           a:=round(a*num);
            b:=round(b*num); //image1.Width:=a; image1.Height:=b;
             button1.Click;
             a:=image1.Width; b:=image1.Height; end;
      2: begin image1.Canvas.Refresh; a:=round(a*num);
          b:=round(b*num);     button2.Click; a:=image1.Width; b:=image1.Height;  end;
      3: begin image1.Canvas.Refresh; a:=round(a*num);
          b:=round(b*num);     button5.Click; a:=image1.Width; b:=image1.Height;  end
      else exit;
    end;
end;

procedure TForm1.Button4Click(Sender: TObject);
begin
close;
end;

procedure TForm1.Button5Click(Sender: TObject);
var i,j,k,nx,ny,n:integer;
    x,y,dx,dy,xk1,yk1:extended;
    c:byte;
begin
  image1.Refresh;  ind:=3;
 // xmin:=-1.5; xmax:=1.5; ymin:=-1.5; ymax:=1.5;
 // a:=image1.Width; b:=image1.Height;
  dx:=(xmax-xmin)/a; dy:=(ymax-ymin)/b;
   for i:=1 to image1.Width do
     for j:=1 to image1.Height do
      begin
        xk1:=xmin+i*dx; yk1:=ymin+j*dy;
         n:=0; x:=1; y:=1;
        while sqrt(sqr(x-xk1)+sqr(y-yk1))>eps do
            begin
               x:=xk1; y:=yk1;
              if ((x=0) and(y=0)) then begin x:=eps; y:=eps; end;
              xk1:=2*x/3+(sqr(x)-sqr(y))/(3*sqr(x*x+y*y));
              yk1:=(2/3)*y*(1-x/(sqr(x*x+y*y)));
              inc(n);
              if n=20 then break;
//              x:=xk1; y:=yk1;
            end;
          c:=round(255*(1-n/20));
          case radiogroup1.ItemIndex of
            0: image1.Canvas.Pixels[i,j]:=rgb(c,c,c);
                       1: image1.Canvas.Pixels[i,j]:=rgb(3*round(sin(n)*c),2*round(sin(n)*c),round(sin(n)*c));
                       2: image1.Canvas.Pixels[i,j]:=rgb(3*c,2*c,c);
          else exit;
      end;
      end;

end;

procedure TForm1.Button1MouseDown(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Integer);
begin
num:=1;  xmin:=-1.5; xmax:=1.5; ymin:=-1.5; ymax:=1.5;
num1:=1.25;   ind3:=1;
end;

procedure TForm1.Button2MouseDown(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Integer);
begin
num:=1;   num1:=1;   ind2:=0;  pmin:=-1.5; qmin:=-1.5; pmax:=1.5; qmax:=1.5;
xmin:=-1.5; xmax:=1.5; ymin:=-1.5; ymax:=1.5;  ind3:=1;
end;

procedure TForm1.Button5MouseDown(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Integer);
begin
num:=1;  num1:=1;  ind2:=0;  xmin:=-1.5; xmax:=1.5; ymin:=-1.5; ymax:=1.5;
ind3:=1;
end;

procedure TForm1.Image1MouseDown(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Integer);
begin
MousePressed := true;
bitmap.Canvas.CopyRect(rect(0,0,image1.Width,image1.Height),image1.Canvas,rect(0,0,image1.Width,image1.Height));
 x1:=x; y1:=y; //  image1.Canvas.Pen.
   xmin1:=(xmax-xmin)*(x)/a+xmin;
   ymin1:=(ymax-ymin)*(y)/b+ymin;
end;


procedure TForm1.Image1MouseUp(Sender: TObject; Button: TMouseButton;
  Shift: TShiftState; X, Y: Integer);
var  step:extended;
begin
MousePressed := false;
  step:=0.25;  expon:=1;
 // image1.Canvas.CopyRect(image1.Canvas.ClipRect, image1.Canvas,(x1,y1,x,y));
    xmax1:=(xmax-xmin)*(x)/a+xmin;
   ymax1:=(ymax-ymin)*(y)/b+ymin;
   if ((xmin1<xmax1) and(ymin1<ymax1)) then begin
      case ind of
        1: begin xmax:=xmax1; xmin:=xmin1; image1.Canvas.Brush.Color:=clwhite;
            image1.Canvas.Rectangle(0,0,image1.Width,image1.Height);
             ymin:=ymin1; ymax:=ymax1;
             if ind3=0 then begin xmin:=-1.5; xmax:=1.5; ymin:=-1.5; ymax:=1.5; end;
              button1.Click;  ind2:=0;  ind3:=1;
                end;
          2: begin pmax:=xmax1; pmin:=xmin1; image1.Canvas.Brush.Color:=clwhite;
           image1.Canvas.Rectangle(0,0,image1.Width,image1.Height);
             qmin:=ymin1; qmax:=ymax1; xmax:=xmax1; xmin:=xmin1;   ymin:=ymin1; ymax:=ymax1;
             if ind3=0 then begin pmin:=-1.5; pmax:=1.5; qmin:=-1.5; qmax:=1.5;
                              xmin:=-1.5; xmax:=1.5; ymin:=-1.5; ymax:=1.5; end;
             button2.Click;  ind2:=0;   ind3:=1;
                end;
          3: begin xmax:=xmax1; xmin:=xmin1; image1.Canvas.Brush.Color:=clwhite;
           image1.Canvas.Rectangle(0,0,image1.Width,image1.Height);
             ymin:=ymin1; ymax:=ymax1;
             if ind3=0 then begin xmin:=-1.5; xmax:=1.5; ymin:=-1.5; ymax:=1.5; end;
             button5.Click;  ind2:=0;   ind3:=1;
                end
          else exit;
      end; end;
    if ((xmin1>xmax1) and(ymin1>ymax1)) then 
      case ind of
        1: begin  num1:=num1*4/5;
                  if num1=0 then begin  num1:=num1*5/4; exit; end else begin
            xmin:=-1.5; xmax:=1.5; ymin:=-1.5; ymax:=1.5;
            image1.Canvas.Brush.Color:=clwhite;
            if ind2=0 then num1:=1;
           image1.Canvas.Rectangle(0,0,image1.Width,image1.Height); a:=round(a*num1);
            b:=round(b*num1);   button1.Click; a:=image1.Width;
            b:=image1.Height;  ind2:=1; ind3:=0; end; end;
         2: begin  num1:=num1*4/5;
                  if num1=0 then begin  num1:=num1*5/4; exit; end else begin
            pmin:=-1.5; pmax:=1.5; qmin:=-1.5; qmax:=1.5;
            xmin:=-1.5; xmax:=1.5; ymin:=-1.5; ymax:=1.5;
            image1.Canvas.Brush.Color:=clwhite;
            if ind2=0 then num1:=1;
           image1.Canvas.Rectangle(0,0,image1.Width,image1.Height); a:=round(a*num1);
            b:=round(b*num1);   button2.Click; a:=image1.Width;
            b:=image1.Height;  ind2:=1; ind3:=0; end; end;
         3: begin  num1:=num1*4/5;
                  if num1=0 then begin  num1:=num1*5/4; exit; end else begin
            xmin:=-1.5; xmax:=1.5; ymin:=-1.5; ymax:=1.5;
            image1.Canvas.Brush.Color:=clwhite;
            if ind2=0 then num1:=1;
           image1.Canvas.Rectangle(0,0,image1.Width,image1.Height); a:=round(a*num1);
            b:=round(b*num1);   button5.Click; a:=image1.Width;
            b:=image1.Height;  ind2:=1; ind3:=0; end; end;
      else exit;
end;
end;

procedure TForm1.Image1MouseMove(Sender: TObject; Shift: TShiftState; X,
  Y: Integer);
begin
if  mousePressed then  begin
image1.Canvas.CopyRect(rect(0,0,image1.Width, image1.Height),bitmap.Canvas,rect(0,0,image1.Width, image1.Height));
bitmap.Canvas.CopyRect(rect(0,0,image1.Width,image1.Height),image1.Canvas,rect(0,0,image1.Width,image1.Height));
  image1.Canvas.Brush.Style:=bsclear;
 image1.Canvas.Rectangle(x1,y1,x,y);   end;
   image1.Canvas.Pen.Color:=clwhite;
//image1.Canvas.Rectangle()age1.Canvas.FrameRect(createrect(1,1,2,2));
{image1.Canvas.brush.Color:=clblack;
//image1.Canvas.Pen
  image1.Canvas.Pen.Mode:=pmxor;
if expon=1 then
    image1.Canvas.FrameRect(rect(x1,y1,x,y));  expon:=0;}

end;




procedure TForm1.FormKeyDown(Sender: TObject; var Key: word;
  Shift: TShiftState);
begin
 //if (shift=[ssshift]) then
 //  begin

      if chr(key)='W'  then
          begin
           ymax:=ymax+0.5; ymin:=ymin+0.5;  // image1.Canvas.Rectangle(0,0,image1.Width,image1.Height);
            case ind of
                 1: begin button1.Click;  end;
                 2: BEGIN qmax:=qmax+0.5; qmin:=qmin+0.5; button2.Click; end;
                 3: button5.Click;
             end;
          end;
      if chr(key)='S' then
          begin
             ymax:=ymax-0.5; ymin:=ymin-0.5;
             case ind of
                 1: button1.Click;
                 2: begin qmax:=qmax-0.5; qmin:=qmin-0.5; button2.Click; end;
                 3: button5.Click;
             end;
          end;
         //  if chr(key)='1'{VK_UP}  then
     if chr(key)='A' then
          begin
             xmax:=xmax+0.5; xmin:=xmin+0.5;
              case ind of
                 1: button1.Click;
                 2: begin pmax:=pmax+0.5; pmin:=pmin+0.5; button2.Click; end;
                 3:  button5.Click;
             end;
          end;
          // if chr(key)='2'{VK_UP}  then
      if chr(key)='D' then
          begin
             xmax:=xmax-0.5; xmin:=xmin-0.5;
             case ind of
                 1: button1.Click;
                 2: begin pmax:=pmax-0.5; pmin:=pmin-0.5; button2.Click; end;
                 3: button5.Click;
             end;
           
          end;
  // end;
end;

procedure TForm1.Edit1KeyPress(Sender: TObject; var Key: Char);
begin
  if not((byte(key)>=byte('0')) and (byte(key)<=byte('9')) or(byte(key)<byte('0'))or(byte(key)=byte('.'))or(byte(key)=byte('-')) or(byte(key)=byte(','))) then
   key:=#0;
end;

procedure TForm1.RadioGroup1Click(Sender: TObject);
var i,j, n: integer;
  c: byte;
begin { c:=round(255*(1-n/100));
 for i:=1 to a do
    for j:=1 to b do
case radiogroup1.ItemIndex of
    0: button1.Click;   c:=round(255*(1-n/100));  image1.Canvas.Pixels[i,j]:=rgb(c,c,c);
     1: button1.Click ;

     image1.Canvas.Pixels[i,j]:=rgb(round(sin(n)*c),0*c,round(cos(n)*c));
    end;  }

    case ind of
      1: button1.Click;
      2: button2.Click;
      3: button5.Click;
    end;

end;

end.
