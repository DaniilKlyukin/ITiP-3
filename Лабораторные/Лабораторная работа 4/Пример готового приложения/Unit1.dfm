object Form1: TForm1
  Left = 182
  Top = 123
  Width = 544
  Height = 443
  Caption = 'Form1'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  KeyPreview = True
  OldCreateOrder = False
  OnCreate = FormCreate
  OnKeyDown = FormKeyDown
  PixelsPerInch = 96
  TextHeight = 13
  object Image1: TImage
    Left = 112
    Top = 96
    Width = 385
    Height = 297
    Stretch = True
    OnMouseDown = Image1MouseDown
    OnMouseMove = Image1MouseMove
    OnMouseUp = Image1MouseUp
  end
  object Label2: TLabel
    Left = 8
    Top = 32
    Width = 12
    Height = 13
    Caption = 'p='
  end
  object Label3: TLabel
    Left = 8
    Top = 56
    Width = 12
    Height = 13
    Caption = 'q='
  end
  object Button1: TButton
    Left = 0
    Top = 8
    Width = 75
    Height = 25
    Caption = #1046#1102#1083#1080#1072
    TabOrder = 0
    OnClick = Button1Click
    OnMouseDown = Button1MouseDown
  end
  object Button2: TButton
    Left = 8
    Top = 88
    Width = 75
    Height = 25
    Caption = #1052#1072#1085#1076#1077#1083#1100#1073#1088#1086#1090
    TabOrder = 1
    OnClick = Button2Click
    OnMouseDown = Button2MouseDown
  end
  object Button3: TButton
    Left = 0
    Top = 360
    Width = 75
    Height = 25
    Caption = 'Button3'
    TabOrder = 2
    Visible = False
  end
  object SpinButton1: TSpinButton
    Left = 32
    Top = 272
    Width = 20
    Height = 25
    DownGlyph.Data = {
      0E010000424D0E01000000000000360000002800000009000000060000000100
      200000000000D800000000000000000000000000000000000000008080000080
      8000008080000080800000808000008080000080800000808000008080000080
      8000008080000080800000808000000000000080800000808000008080000080
      8000008080000080800000808000000000000000000000000000008080000080
      8000008080000080800000808000000000000000000000000000000000000000
      0000008080000080800000808000000000000000000000000000000000000000
      0000000000000000000000808000008080000080800000808000008080000080
      800000808000008080000080800000808000}
    TabOrder = 3
    UpGlyph.Data = {
      0E010000424D0E01000000000000360000002800000009000000060000000100
      200000000000D800000000000000000000000000000000000000008080000080
      8000008080000080800000808000008080000080800000808000008080000080
      8000000000000000000000000000000000000000000000000000000000000080
      8000008080000080800000000000000000000000000000000000000000000080
      8000008080000080800000808000008080000000000000000000000000000080
      8000008080000080800000808000008080000080800000808000000000000080
      8000008080000080800000808000008080000080800000808000008080000080
      800000808000008080000080800000808000}
    OnDownClick = SpinButton1DownClick
    OnUpClick = SpinButton1UpClick
  end
  object Button4: TButton
    Left = 0
    Top = 136
    Width = 81
    Height = 25
    Caption = 'Close'
    TabOrder = 4
    OnClick = Button4Click
  end
  object Button5: TButton
    Left = 0
    Top = 112
    Width = 81
    Height = 25
    Caption = #1053#1100#1102#1090#1086#1085
    TabOrder = 5
    OnClick = Button5Click
    OnMouseDown = Button5MouseDown
  end
  object Edit1: TEdit
    Left = 24
    Top = 56
    Width = 121
    Height = 21
    TabOrder = 6
    Text = '-0,55'
    OnKeyPress = Edit1KeyPress
  end
  object Edit2: TEdit
    Left = 24
    Top = 32
    Width = 121
    Height = 21
    TabOrder = 7
    Text = '-0,55'
  end
  object RadioGroup1: TRadioGroup
    Left = 240
    Top = 8
    Width = 185
    Height = 73
    Caption = #1080#1079#1086#1073#1088#1072#1078#1077#1085#1080#1077
    Items.Strings = (
      #1095#1077#1088#1085#1086'-'#1073#1077#1083#1086#1077
      #1094#1074#1077#1090#1085#1086#1077
      #1094#1074#1077#1090#1085#1086#1077'('#1085#1077#1089#1084#1077#1096#1072#1085#1085#1086#1077')')
    TabOrder = 8
    OnClick = RadioGroup1Click
  end
end
