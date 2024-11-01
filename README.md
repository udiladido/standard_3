# 모범 답



---

# 내가 정리했던 내용
<details>

# Q1

## InputSystem


https://rootdev.tistory.com/42


https://rootdev.tistory.com/44


https://rootdev.tistory.com/54


### Invoke Event와 SendMessage 비교


### 공통점 : 
Event 기반

### 차이점 : 

##### SendMessage 방식:

On + 이름으로 입력에 따라 이벤트 발생 (성능이 상대적으로 낮다), 


런타임 체크(리플렉션), 문자열 기반, 

InputValue를 매개변수 사용하고
Get<T>을 통해 처리.


#### Invoke Event 방식: 
인스펙터에서 연결해 이벤트 발생 (결합도 높다), 


컴파일 타임 체크

InputAction.CallbackContext로 받고
ReadValue<T>로 처리.


## Move와 CameraLook 함수 FixedUpdate, LateUpdate 하는 이유

카메라가 플레이어를 따라가야하니까 플레이어 움직임 보다 나중에 동작해야한다. 


( 둘다 Update로 실행하면 플레이어 움직임과 카메라 둘 중 어떤 게 먼저 동작될 지 알 수 없음. = 버벅임 문제)


move의 경우 물리를 통해 움직이니까 FixedUpdate 사용해야 한다.

(Fixedupdate는 일정한 시간 간격으로 호출. / 안정적이다. )


(Update의 경우로 하면 기기 성능에 따른 프레임마다 달라질 수 있다.)


---


# Q2

## 별도 UI 스크립트 만드는 이유 객체 지향적 관점 분석

보통 팩토리 패턴( 추상 팩토리 패턴) 사용


https://rootdev.tistory.com/55


## 인터페이스 특징 정리 (+ 추상 클래스 정리): 


https://rootdev.tistory.com/31 


### 인터페이스
메서드를 정의만 할 뿐 구현을 갖지 않는다.


모든 맴버가 public이다.
 
### 추상클래스 


일부 동작 구현을 가지며, 추상 메서드를 포함 할 수 있다.


클래스이므로 단일 상속만 가능하다.


---


# Q3

## ScriptableObject 프리팹 말고 게임오브젝트로 바로 생성 시도

 

</Deatails>
