# Gong Solutions Shell Library

The Gong Solutions Shell Library provides controls to enable embedding Windows Explorer-like functionality into .Net 2.0 programs and for creating custom file dialogs. It provides a clean interface into the Windows Shell Namespace from code, allowing easy access to virtual folders such as the Recycle Bin.

이 라이브러리는 파일 탐색기(Windows Explorer)의 기능 일부를 .NET Framework WInForm에서 사용할 수 있게 도와주는 라이브러리입니다.

내부에서 Windows Shell API를 사용합니다.

[원본 프로젝트 페이지](http://gong-shell.sourceforge.net/)

![Gong Solutions Shell Library](http://gong-shell.sourceforge.net/images/filedialog-screen.png)

## Easily Create Cusom File Dialogs

Using the Gong Solutions Shell Library, you can create custom file dialogs with just a few lines of code. Just drop a FileDialogToolbar control and a ShellView control onto your form, link them together and you have a basic file dialog!

## Embed Windows Explorer in your Applications

Using the Gong Solutions Shell Library, you can embed Windows explorer in your applications by simply adding two controls. Just drop a ShellTreeView control and a ShellView control onto your form, link them together and you can be browsing in no time!

## Access the Windows Shell from Code

The Windows Shell is a notoriously difficult API to code to. The Gong Solutions Shell Library provides a clean, flexible, user friendly route into the Shell Namespace from code

## 변경사항

- 솔루션 파일을 VS2019로 변경
- .NET Framework 버전 4.8로 수정
- 라이브러리 수정
  - OverflowException 예외 수정
  - PlacesToolbar.WrapButtonText() 버그 수정
  - ShellItem.GetHashCode() 경고 수정
  - CS1591 경고 제외
- 예제 소스 수정
  - High DPI 지원 수정  
    [MS 가이드](https://docs.microsoft.com/ko-kr/dotnet/desktop/winforms/high-dpi-support-in-windows-forms?view=netframeworkdesktop-4.8)
  - 폰트를 기본 폰트 사용하도록 수정
  - Null 참조 예외 수정
- Test 소스 수정
  - NuGet 패키지 NUnit 3.13.2 로 변경
